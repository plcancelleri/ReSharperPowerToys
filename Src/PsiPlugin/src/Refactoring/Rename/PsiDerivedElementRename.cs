﻿using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using JetBrains.Application;
using JetBrains.Application.Progress;
using JetBrains.ReSharper.Feature.Services.Util;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.PsiPlugin.Grammar;
using JetBrains.ReSharper.Refactorings;
using JetBrains.ReSharper.Refactorings.Conflicts;
using JetBrains.ReSharper.Refactorings.Conflicts.New;
using JetBrains.ReSharper.Refactorings.Rename;
using JetBrains.ReSharper.Refactorings.RenameModel;
using JetBrains.ReSharper.Refactorings.Util;
using JetBrains.ReSharper.Refactorings.Workflow;
using JetBrains.Util;

namespace JetBrains.ReSharper.PsiPlugin.Refactoring.Rename
{
  class PsiDerivedElementRename : AtomicRenameBase
  {
    private readonly IDeclaredElementPointer<IDeclaredElement> myOriginalElementPointer;
    private readonly string myNewName;
    private readonly bool myDoNotShowBindingConflicts;

    private IDeclaredElementPointer<IDeclaredElement> myNewElementPointer;
    private readonly List<IReference> myNewReferences = new List<IReference>();
    private readonly List<IDeclaration> myDeclarations = new List<IDeclaration>();
    [CanBeNull] private readonly List<IDeclaredElementPointer<IDeclaredElement>> mySecondaryElements;



    public override IDeclaredElement NewDeclaredElement
    {
      get { return myNewElementPointer.FindDeclaredElement(); }
    }

    public override string NewName
    {
      get { return myNewName; }
    }

    public override IDeclaredElement PrimaryDeclaredElement
    {
      get { return myOriginalElementPointer.FindDeclaredElement(); }
    }

    [NotNull]
    public override IList<IDeclaredElement> SecondaryDeclaredElements
    {
      get
      {
        if (mySecondaryElements == null)
          return EmptyList<IDeclaredElement>.InstanceList;
        return mySecondaryElements.SelectNotNull(x => x.FindDeclaredElement()).ToList();
      }
    }

    public PsiDerivedElementRename(IDeclaredElement declaredElement, [NotNull] string newName, bool doNotShowBindingConflicts)
    {
      myOriginalElementPointer = declaredElement.CreateElementPointer();
      myNewName = newName;
      myDoNotShowBindingConflicts = doNotShowBindingConflicts;
      mySecondaryElements = new List<IDeclaredElementPointer<IDeclaredElement>>();
      mySecondaryElements = RenameRefactoringService.Instance.GetRenameService(PsiLanguage.Instance).GetSecondaryElements(declaredElement).Select(x => x.CreateElementPointer()).ToList();
      BuildDeclarations();
    }

    public override void Rename(RenameRefactoring executer, IProgressIndicator pi, bool hasConflictsWithDeclarations, IRefactoringDriver driver)
    {
      BuildDeclarations();

      //Logger.Assert(myDeclarations.Count > 0, "myDeclarations.Count > 0");

      var declaredElement = myOriginalElementPointer.FindDeclaredElement();
      if (declaredElement == null) return;

      var psiServices = declaredElement.GetPsiServices();

      var primaryReferences = executer.Workflow.GetElementReferences(PrimaryDeclaredElement);
      var secondaryElementWithReferences = SecondaryDeclaredElements.Select(x => Pair.Of(x, executer.Workflow.GetElementReferences(x))).ToList();
      pi.Start(myDeclarations.Count + primaryReferences.Count);

      foreach (var declaration in myDeclarations)
      {
        InterruptableActivityCookie.CheckAndThrow(pi);
        declaration.SetName(myNewName);
        pi.Advance();
      }

      psiServices.PsiManager.UpdateCaches();

      IDeclaredElement newDeclaredElement = null;
      if (myDeclarations.Count > 0)
      {
        newDeclaredElement = myDeclarations[0].DeclaredElement;
      } 

      Assertion.Assert(newDeclaredElement != null, "The condition (newDeclaredElement != null) is false.");
      if (newDeclaredElement != null)
      {
        myNewElementPointer = newDeclaredElement.CreateElementPointer();
        Assertion.Assert(newDeclaredElement.IsValid(), "myNewDeclaredElement.IsValid()");
      } else
      {
        return;
      }

      myNewReferences.Clear();
      var references = LanguageUtil.SortReferences(primaryReferences.Where(x => x.IsValid()));
      IList<IReference> referencesToRename = new List<IReference>();
      foreach (var pair in references)
      {
        var sortedReferences = LanguageUtil.GetSortedReferences(pair.Value);
        foreach (var reference in sortedReferences)
        {
          var oldReferenceForConflict = reference;
          InterruptableActivityCookie.CheckAndThrow(pi);
          if (reference.IsValid()) // reference may invalidate during additional reference processing
          {
            var rename = executer.Workflow.LanguageSpecific[reference.GetTreeNode().Language];
            var reference1 = rename.TransformProjectedInitializer(reference);
            var subst = GetSubst(newDeclaredElement, executer);
            IReference newReference;
            if (subst != null)
            {
              if (subst.Substitution.Domain.IsEmpty())
                newReference = reference1.BindTo(subst.Element);
              else
                newReference = reference1.BindTo(subst.Element, subst.Substitution);
            }
            else
            {
              newReference = reference1.BindTo(newDeclaredElement);
            }
            if (!(newReference is IImplicitReference))
            {
              var element = newReference.Resolve().DeclaredElement;
              if (!hasConflictsWithDeclarations && !myDoNotShowBindingConflicts && (element == null || !element.Equals(newDeclaredElement)) && !rename.IsAlias(newDeclaredElement))
              {
                driver.AddLateConflict(() => new Conflict(newReference.GetTreeNode().GetSolution(), "Usage {0} can not be updated correctly.", ConflictSeverity.Error, oldReferenceForConflict), "not bound");
              }
              referencesToRename.Add(newReference);
            }
            myNewReferences.Insert(0, newReference);
            rename.AdditionalReferenceProcessing(newDeclaredElement, newReference, myNewReferences);
          }

          pi.Advance();
        }
      }

      foreach (var pair in secondaryElementWithReferences)
      {
        var element = pair.First;
        var secondaryReferences = pair.Second;
        foreach (var reference in secondaryReferences)
        {
          InterruptableActivityCookie.CheckAndThrow(pi);
          if (reference.IsValid())
          {
            reference.BindTo(element);
          }
        }
      }
    }

    private static DeclaredElementInstance GetSubst(IDeclaredElement element, RenameRefactoring executer)
    {
      return executer.Workflow.LanguageSpecific[element.PresentationLanguage].GetSubst(element);
    }

    private void BuildDeclarations()
    {
      myDeclarations.Clear();

      var element = myOriginalElementPointer.FindDeclaredElement();
      if (element == null)
        return;

      var declarations = new MultyPsiDeclarations(element).AllDeclarations;

      foreach (var declaration in declarations)
      {
        myDeclarations.Add(declaration);
      }
    }
  }
}
