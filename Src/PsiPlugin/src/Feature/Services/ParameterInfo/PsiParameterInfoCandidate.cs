﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JetBrains.ReSharper.Feature.Services.ParameterInfo;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Util;
using JetBrains.ReSharper.PsiPlugin.Grammar;
using JetBrains.ReSharper.PsiPlugin.Psi.Psi.Tree;
using JetBrains.ReSharper.PsiPlugin.Psi.Psi.Tree.Impl;
using JetBrains.UI.RichText;
using JetBrains.Util;

namespace JetBrains.ReSharper.PsiPlugin.Feature.Services.ParameterInfo
{
  public class PsiParameterInfoCandidate : ICandidate
  {
    private readonly IDeclaredElement[] myParameters;
    private readonly TextRange[] myParameterRanges;
    private readonly string mySignature;

    #region Implementation of ICandidate

    public  PsiParameterInfoCandidate(PsiRuleSignature signature, IPsiSourceFile sourceFile)
    {
      myParameters = signature.Parameters.ToArray();
      myParameterRanges = new TextRange[myParameters.Length];

      mySignature = "[";

      int i = 0;
      foreach (var parameter in myParameters)
      {
        mySignature += parameter.ShortName;
        if (i < myParameters.Count() - 1)
        {
          mySignature += ",";
        }
        ++i;
      }
      mySignature += "]";
    }

    public override int GetHashCode()
    {
      return (mySignature != null ? mySignature.GetHashCode() : 0);
    }

    public RichText GetSignature(string[] namedArguments, out TextRange[] parameterRanges, out int[] mapToOriginalOrder, out ExtensionMethodInfo extensionMethodInfo)
    {
      parameterRanges = myParameterRanges;
      mapToOriginalOrder = Enumerable.Range(0, myParameterRanges.Length).ToArray();
      extensionMethodInfo = null;
      return new RichText(mySignature);
    }

    public void GetParametersInfo(out string[] paramNames, out RichTextBlock[] paramDescriptions, out bool isParamsArray)
    {
      paramNames = myParameters.Select(x => GetShortName(x)).ToArray();
      isParamsArray = false;
      //if (myDocSignature != null)
      //{
        paramDescriptions = GetParamDescriptions();
      //}
      //else
      //{
        //paramDescriptions = new RichTextBlock[PositionalParameterCount];
      //}
    }

    public RichTextBlock[] GetParamDescriptions()
    {
      var parameters = myParameters;
      var paramDescriptions = new RichTextBlock[parameters.Count()];

      var i = 0;
      foreach (RuleDeclaration parameter in parameters)
      {
        paramDescriptions[i] = XmlDocRichTextPresenter.Run(
          XMLDocUtil.ExtractParameterSummary(null, parameter.ShortName),
          parameter.GetPsiModule(), false, PsiLanguage.Instance);
        i++;
      }

      return paramDescriptions;
    }

    private string GetShortName(IDeclaredElement declaredElement)
    {
      return declaredElement.ShortName;
    }

    public RichTextBlock GetDescription()
    {
      return GetParamDescriptions()[0];
    }

    public bool Matches(IDeclaredElement signature)
    {
      return true;
    }

    public bool IsFilteredOut { get; set; }
    public int PositionalParameterCount { get; private set; }
    public bool IsObsolete
    {
      get { return false; }
    }
    public RichTextBlock ObsoleteDescription
    {
      get { return null; }
    }

    #endregion
  }

  public class PsiRuleSignature
  {
    private IList<IDeclaredElement> myParameters = new List<IDeclaredElement>();
    private IRuleDeclaration myRuleDeclaration;
    private IPsiSourceFile mySourceFile;

    public PsiRuleSignature(IRuleDeclaration ruleDeclaration)
    {
      var parameters = ruleDeclaration.Parameters;
      myRuleDeclaration = ruleDeclaration;
      mySourceFile = myRuleDeclaration.GetSourceFile();
      if(parameters != null)
      {
        var child = parameters.FirstChild;
        while(child != null)
        {
          var ruleName = child as IRuleName;
          if(ruleName != null)
          {
            var declaredElement = ruleName.RuleNameReference.Resolve().DeclaredElement;
            if (declaredElement != null)
            {
              myParameters.Add(declaredElement);
            } else
            {
              var candidates = ruleName.RuleNameReference.Resolve().Result.Candidates;
              foreach(var candidate in candidates)
              {
                if (candidate is IRuleDeclaration)
                {
                  myParameters.Add(candidate);
                  break;
                }
              }
            }
          }
          child = child.NextSibling;
        }
      }
    }

    public IList<IDeclaredElement> Parameters { 
      get
      {
        return myParameters;
      }
    }

    public int ParametersCount
    {
      get
      {
        return myParameters.Count;
      }
    }

    public IPsiSourceFile SourceFile
    {
      get
      {
        return mySourceFile;
      }
    }
  }
}