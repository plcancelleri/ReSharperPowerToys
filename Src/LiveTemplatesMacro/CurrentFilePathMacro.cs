using System.Collections.Generic;
using JetBrains.DocumentManagers;
using JetBrains.DocumentModel;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Feature.Services.Lookup;
using JetBrains.Util;

namespace JetBrains.ReSharper.PowerToys.LiveTemplatesMacro
{
  [Macro("LiveTemplatesMacro.CurrentFilePath", // macro name should be unique among all other macros, it's recommended to prefix it with your plugin name to achieve that
    ShortDescription = "Current file path", // description of the macro to be shown in the list of macros
    LongDescription="Evaluates current file path" // long description of the macro to be shown in the area below the list
    )]
  public class CurrentFilePathMacro : IMacro
  {
    #region Implementation

    private static string Evaluate(IHotspotContext context)
    {
      var ctx = context.SessionContext;
      IDocument currentDocument = ctx.TextControl.Document;
      IProjectFile projectItem = ctx.Solution.GetComponent<DocumentManager>().GetProjectFile(currentDocument);
      return projectItem.Location.FullPath;
    }

    #endregion

    #region IMacro Members

    public string EvaluateQuickResult(IHotspotContext context, IList<string> arguments)
    {
      return Evaluate(context);
    }

    public HotspotItems GetLookupItems(IHotspotContext context, IList<string> arguments)
    {
      return new HotspotItems(new TextLookupItem(Evaluate(context)));
    }

    public string GetPlaceholder(IDocument document)
    {
      return "a";
    }

    public bool HandleExpansion(IHotspotContext context, IList<string> arguments)
    {
      return false;
    }

    public ParameterInfo[] Parameters
    {
      get
      {
        return EmptyArray<ParameterInfo>.Instance;
      }
    }

    #endregion
  }
}