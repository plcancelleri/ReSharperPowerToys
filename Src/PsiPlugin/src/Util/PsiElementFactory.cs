﻿using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.PsiPlugin.Tree;

namespace JetBrains.ReSharper.PsiPlugin.Util
{
  public abstract class PsiElementFactory
  {
    public static PsiElementFactory GetInstance([NotNull] IPsiModule module)
    {
      return new PsiElementFactoryImpl(module);
    }

    public static PsiElementFactory GetInstance([NotNull] ITreeNode context)
    {
      //return new PsiElementFactoryImpl(context.GetPsiModule(), context.Language, true);
      return new PsiElementFactoryImpl(context.GetPsiModule());
    }

    public abstract IRuleName CreateIdentifierExpression(string name);

    protected ISolution Solution { get; set; }
  }
}
