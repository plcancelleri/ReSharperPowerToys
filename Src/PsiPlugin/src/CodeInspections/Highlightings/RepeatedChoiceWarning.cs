using JetBrains.DocumentModel;
using JetBrains.ReSharper.Daemon;
using JetBrains.ReSharper.Daemon.Impl;
using JetBrains.ReSharper.Psi.Tree;

[assembly: RegisterConfigurableSeverity("Repeated Choice", null, HighlightingGroupIds.LanguageUsage, "Repeated Choice", @"
          Repeated Choice", Severity.WARNING, false, Internal = false)]

namespace JetBrains.ReSharper.PsiPlugin.CodeInspections.Highlightings
{
  [ConfigurableSeverityHighlighting("Repeated Choice", "PSI", OverlapResolve = OverlapResolveKind.NONE, ToolTipFormatString = "Repeated Choice")]
  //[StaticSeverityHighlighting(Severity.INFO, HighlightingGroupIds.CompilerWarnings,
    //OverlapResolve = OverlapResolveKind.WARNING, ShowToolTipInStatusBar = false)]
  class RepeatedChoiceWarning : IHighlightingWithRange, ICustomAttributeIdHighlighting
  {
    private readonly ITreeNode myElement;
    private const string Error = "Repeated choice";
    private const string AtributeId = HighlightingAttributeIds.WARNING_ATTRIBUTE;

    public RepeatedChoiceWarning(ITreeNode element)
    {
      myElement = element;
    }

    public bool IsValid()
    {
      return true;
    }

    public string ToolTip
    {
      get { return Error; }
    }

    public string ErrorStripeToolTip
    {
      get { return Error; }
    }

    public int NavigationOffsetPatch
    {
      get { return 0; }
    }

    public DocumentRange CalculateRange()
    {
      return myElement.GetNavigationRange();
    }

    public string AttributeId
    {
      get { return AtributeId; }
    }
  }
}
