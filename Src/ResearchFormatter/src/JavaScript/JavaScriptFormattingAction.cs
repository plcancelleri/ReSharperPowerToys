﻿using JetBrains.Application;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Bulbs;
using JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs;
using JetBrains.ReSharper.Intentions.Extensibility;
using JetBrains.ReSharper.Intentions.Extensibility.Menu;
using JetBrains.ReSharper.Intentions.JavaScript.ContextActions;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CodeStyle;
using JetBrains.ReSharper.Psi.ExtensionsAPI;
using JetBrains.TextControl;
using JetBrains.Util;

namespace JetBrains.ReSharper.ResearchFormatter.JavaScript
{
  [ContextAction(Group = JavaScriptContextActions.GroupID, Name = "formatJavascript", Description = "format javascript.", Priority = -1)]
  public class JavaScriptFormattingAction : IContextAction, IBulbAction
  {
    private readonly IJavaScriptContextActionDataProvider myProvider;

    public JavaScriptFormattingAction(IJavaScriptContextActionDataProvider provider)
    {
      myProvider = provider;
    }

    public void CreateBulbItems(BulbMenu menu)
    {
      menu.ArrangeContextAction(this);
    }

    public bool IsAvailable(IUserDataHolder cache)
    {
      //todo
      return myProvider.Selection.Length > 0;
    }

    public void Execute(ISolution solution, ITextControl textControl)
    {
      var formatter = JavaScriptResearchFormatter.Instance;
      var startOffset = myProvider.Selection.StartOffset;
      var endOffset = myProvider.Selection.EndOffset;
      var nodeFirst = myProvider.PsiFile.FindTokenAt(new TreeOffset(startOffset));
      var nodeLast = myProvider.PsiFile.FindTokenAt(new TreeOffset(endOffset - 1));
      var psiServices = myProvider.PsiServices;
      using (new DisableCodeFormatter())
      {
        using (PsiTransactionCookie.CreateAutoCommitCookieWithCachesUpdate(psiServices, "Format code"))
        {
          using (WriteLockCookie.Create())
          {
            formatter.Format(nodeFirst, nodeLast, CodeFormatProfile.DEFAULT);
          }
        }
      }
    }

    public string Text { get { return "format javascript"; } }
  }
}
