﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.Annotations;
using JetBrains.Application.Settings;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.PsiPlugin.LexGrammar;
using JetBrains.ReSharper.PsiPlugin.Psi.Lex.Tree;

namespace JetBrains.ReSharper.PsiPlugin.CodeInspections.Lex
{
  public abstract class LexDaemonStageBase : IDaemonStage
  {
    #region IDaemonStage Members

    public abstract IEnumerable<IDaemonStageProcess> CreateProcess(IDaemonProcess process, IContextBoundSettingsStore settings, DaemonProcessKind processKind);

    public virtual ErrorStripeRequest NeedsErrorStripe(IPsiSourceFile sourceFile, IContextBoundSettingsStore settings)
    {
      if (!IsSupported(sourceFile))
      {
        return ErrorStripeRequest.NONE;
      }

      var properties = sourceFile.Properties;
      if (!properties.ProvidesCodeModel || properties.IsNonUserFile)
      {
        return ErrorStripeRequest.NONE;
      }

      return ErrorStripeRequest.STRIPE_AND_ERRORS;
    }

    #endregion

    [CanBeNull]
    public static ILexFile GetPsiFile(IPsiSourceFile sourceFile)
    {
      PsiManager manager = PsiManager.GetInstance(sourceFile.GetSolution());
      manager.AssertAllDocumentAreCommited();
      return manager.GetPsiFile<LexLanguage>(new DocumentRange(sourceFile.Document, 0)) as ILexFile;
    }

    protected bool IsSupported(IPsiSourceFile sourceFile)
    {
      if (sourceFile == null || !sourceFile.IsValid())
      {
        return false;
      }

      ILexFile lexFile = GetPsiFile(sourceFile);
      return lexFile != null && lexFile.Language.Is<LexLanguage>();
    }
  }
}