﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by TokenGenerator
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using JetBrains.ReSharper.Psi.Parsing;

namespace JetBrains.ReSharper.PsiPlugin.Psi.Lex.Parsing
{
  public static partial class LexTokenType
  {
    #region USING_KEYWORD
    private class UsingKeywordNodeType : KeywordTokenNodeType
    {
      public UsingKeywordNodeType(): base ("USING_KEYWORD", "using") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new UsingKeywordTokenElement(this);
      }
    }
    private class UsingKeywordTokenElement : FixedTokenElement
    {
      public UsingKeywordTokenElement(UsingKeywordNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType USING_KEYWORD = new UsingKeywordNodeType();
    #endregion
    #region INIT_KEYWORD
    private class InitKeywordNodeType : KeywordTokenNodeType
    {
      public InitKeywordNodeType(): base ("INIT_KEYWORD", "init") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new InitKeywordTokenElement(this);
      }
    }
    private class InitKeywordTokenElement : FixedTokenElement
    {
      public InitKeywordTokenElement(InitKeywordNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType INIT_KEYWORD = new InitKeywordNodeType();
    #endregion
    #region INCLUDE_KEYWORD
    private class IncludeKeywordNodeType : KeywordTokenNodeType
    {
      public IncludeKeywordNodeType(): base ("INCLUDE_KEYWORD", "include") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new IncludeKeywordTokenElement(this);
      }
    }
    private class IncludeKeywordTokenElement : FixedTokenElement
    {
      public IncludeKeywordTokenElement(IncludeKeywordNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType INCLUDE_KEYWORD = new IncludeKeywordNodeType();
    #endregion

    #region LPARENTH
    private class LparenthNodeType : FixedTokenNodeType
    {
      public LparenthNodeType(): base ("LPARENTH", "(") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LparenthTokenElement(this);
      }
    }
    private class LparenthTokenElement : FixedTokenElement
    {
      public LparenthTokenElement(LparenthNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LPARENTH = new LparenthNodeType();
    #endregion
    #region RPARENTH
    private class RparenthNodeType : FixedTokenNodeType
    {
      public RparenthNodeType(): base ("RPARENTH", ")") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new RparenthTokenElement(this);
      }
    }
    private class RparenthTokenElement : FixedTokenElement
    {
      public RparenthTokenElement(RparenthNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType RPARENTH = new RparenthNodeType();
    #endregion
    #region LBRACE
    private class LbraceNodeType : FixedTokenNodeType
    {
      public LbraceNodeType(): base ("LBRACE", "{") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LbraceTokenElement(this);
      }
    }
    private class LbraceTokenElement : FixedTokenElement
    {
      public LbraceTokenElement(LbraceNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LBRACE = new LbraceNodeType();
    #endregion
    #region RBRACE
    private class RbraceNodeType : FixedTokenNodeType
    {
      public RbraceNodeType(): base ("RBRACE", "}") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new RbraceTokenElement(this);
      }
    }
    private class RbraceTokenElement : FixedTokenElement
    {
      public RbraceTokenElement(RbraceNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType RBRACE = new RbraceNodeType();
    #endregion
    #region LBRACKET
    private class LbracketNodeType : FixedTokenNodeType
    {
      public LbracketNodeType(): base ("LBRACKET", "[") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LbracketTokenElement(this);
      }
    }
    private class LbracketTokenElement : FixedTokenElement
    {
      public LbracketTokenElement(LbracketNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LBRACKET = new LbracketNodeType();
    #endregion
    #region RBRACKET
    private class RbracketNodeType : FixedTokenNodeType
    {
      public RbracketNodeType(): base ("RBRACKET", "]") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new RbracketTokenElement(this);
      }
    }
    private class RbracketTokenElement : FixedTokenElement
    {
      public RbracketTokenElement(RbracketNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType RBRACKET = new RbracketNodeType();
    #endregion
    #region SEMICOLON
    private class SemicolonNodeType : FixedTokenNodeType
    {
      public SemicolonNodeType(): base ("SEMICOLON", ";") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new SemicolonTokenElement(this);
      }
    }
    private class SemicolonTokenElement : FixedTokenElement
    {
      public SemicolonTokenElement(SemicolonNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType SEMICOLON = new SemicolonNodeType();
    #endregion
    #region COMMA
    private class CommaNodeType : FixedTokenNodeType
    {
      public CommaNodeType(): base ("COMMA", ",") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new CommaTokenElement(this);
      }
    }
    private class CommaTokenElement : FixedTokenElement
    {
      public CommaTokenElement(CommaNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType COMMA = new CommaNodeType();
    #endregion
    #region DOT
    private class DotNodeType : FixedTokenNodeType
    {
      public DotNodeType(): base ("DOT", ".") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new DotTokenElement(this);
      }
    }
    private class DotTokenElement : FixedTokenElement
    {
      public DotTokenElement(DotNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType DOT = new DotNodeType();
    #endregion
    #region EQ
    private class EqNodeType : FixedTokenNodeType
    {
      public EqNodeType(): base ("EQ", "=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new EqTokenElement(this);
      }
    }
    private class EqTokenElement : FixedTokenElement
    {
      public EqTokenElement(EqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType EQ = new EqNodeType();
    #endregion
    #region GT
    private class GtNodeType : FixedTokenNodeType
    {
      public GtNodeType(): base ("GT", ">") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new GtTokenElement(this);
      }
    }
    private class GtTokenElement : FixedTokenElement
    {
      public GtTokenElement(GtNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType GT = new GtNodeType();
    #endregion
    #region LT
    private class LtNodeType : FixedTokenNodeType
    {
      public LtNodeType(): base ("LT", "<") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LtTokenElement(this);
      }
    }
    private class LtTokenElement : FixedTokenElement
    {
      public LtTokenElement(LtNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LT = new LtNodeType();
    #endregion
    #region EXCL
    private class ExclNodeType : FixedTokenNodeType
    {
      public ExclNodeType(): base ("EXCL", "!") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new ExclTokenElement(this);
      }
    }
    private class ExclTokenElement : FixedTokenElement
    {
      public ExclTokenElement(ExclNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType EXCL = new ExclNodeType();
    #endregion
    #region TILDE
    private class TildeNodeType : FixedTokenNodeType
    {
      public TildeNodeType(): base ("TILDE", "~") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new TildeTokenElement(this);
      }
    }
    private class TildeTokenElement : FixedTokenElement
    {
      public TildeTokenElement(TildeNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType TILDE = new TildeNodeType();
    #endregion
    #region SHARP
    private class SharpNodeType : FixedTokenNodeType
    {
      public SharpNodeType(): base ("SHARP", "#") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new SharpTokenElement(this);
      }
    }
    private class SharpTokenElement : FixedTokenElement
    {
      public SharpTokenElement(SharpNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType SHARP = new SharpNodeType();
    #endregion
    #region AT
    private class AtNodeType : FixedTokenNodeType
    {
      public AtNodeType(): base ("AT", "@") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AtTokenElement(this);
      }
    }
    private class AtTokenElement : FixedTokenElement
    {
      public AtTokenElement(AtNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType AT = new AtNodeType();
    #endregion
    #region BACK_QUOTE
    private class BackQuoteNodeType : FixedTokenNodeType
    {
      public BackQuoteNodeType(): base ("BACK_QUOTE", "`") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new BackQuoteTokenElement(this);
      }
    }
    private class BackQuoteTokenElement : FixedTokenElement
    {
      public BackQuoteTokenElement(BackQuoteNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType BACK_QUOTE = new BackQuoteNodeType();
    #endregion
    #region QUEST
    private class QuestNodeType : FixedTokenNodeType
    {
      public QuestNodeType(): base ("QUEST", "?") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new QuestTokenElement(this);
      }
    }
    private class QuestTokenElement : FixedTokenElement
    {
      public QuestTokenElement(QuestNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType QUEST = new QuestNodeType();
    #endregion
    #region COLON
    private class ColonNodeType : FixedTokenNodeType
    {
      public ColonNodeType(): base ("COLON", ":") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new ColonTokenElement(this);
      }
    }
    private class ColonTokenElement : FixedTokenElement
    {
      public ColonTokenElement(ColonNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType COLON = new ColonNodeType();
    #endregion
    #region PLUS
    private class PlusNodeType : FixedTokenNodeType
    {
      public PlusNodeType(): base ("PLUS", "+") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new PlusTokenElement(this);
      }
    }
    private class PlusTokenElement : FixedTokenElement
    {
      public PlusTokenElement(PlusNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType PLUS = new PlusNodeType();
    #endregion
    #region MINUS
    private class MinusNodeType : FixedTokenNodeType
    {
      public MinusNodeType(): base ("MINUS", "-") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new MinusTokenElement(this);
      }
    }
    private class MinusTokenElement : FixedTokenElement
    {
      public MinusTokenElement(MinusNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType MINUS = new MinusNodeType();
    #endregion
    #region ASTERISK
    private class AsteriskNodeType : FixedTokenNodeType
    {
      public AsteriskNodeType(): base ("ASTERISK", "*") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AsteriskTokenElement(this);
      }
    }
    private class AsteriskTokenElement : FixedTokenElement
    {
      public AsteriskTokenElement(AsteriskNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType ASTERISK = new AsteriskNodeType();
    #endregion
    #region DIV
    private class DivNodeType : FixedTokenNodeType
    {
      public DivNodeType(): base ("DIV", "/") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new DivTokenElement(this);
      }
    }
    private class DivTokenElement : FixedTokenElement
    {
      public DivTokenElement(DivNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType DIV = new DivNodeType();
    #endregion
    #region BACK_SLASH
    private class BackSlashNodeType : FixedTokenNodeType
    {
      public BackSlashNodeType(): base ("BACK_SLASH", "\\") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new BackSlashTokenElement(this);
      }
    }
    private class BackSlashTokenElement : FixedTokenElement
    {
      public BackSlashTokenElement(BackSlashNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType BACK_SLASH = new BackSlashNodeType();
    #endregion
    #region AND
    private class AndNodeType : FixedTokenNodeType
    {
      public AndNodeType(): base ("AND", "&") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AndTokenElement(this);
      }
    }
    private class AndTokenElement : FixedTokenElement
    {
      public AndTokenElement(AndNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType AND = new AndNodeType();
    #endregion
    #region OR
    private class OrNodeType : FixedTokenNodeType
    {
      public OrNodeType(): base ("OR", "|") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new OrTokenElement(this);
      }
    }
    private class OrTokenElement : FixedTokenElement
    {
      public OrTokenElement(OrNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType OR = new OrNodeType();
    #endregion
    #region XOR
    private class XorNodeType : FixedTokenNodeType
    {
      public XorNodeType(): base ("XOR", "^") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new XorTokenElement(this);
      }
    }
    private class XorTokenElement : FixedTokenElement
    {
      public XorTokenElement(XorNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType XOR = new XorNodeType();
    #endregion
    #region PERC
    private class PercNodeType : FixedTokenNodeType
    {
      public PercNodeType(): base ("PERC", "%") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new PercTokenElement(this);
      }
    }
    private class PercTokenElement : FixedTokenElement
    {
      public PercTokenElement(PercNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType PERC = new PercNodeType();
    #endregion
    #region EQEQ
    private class EqeqNodeType : FixedTokenNodeType
    {
      public EqeqNodeType(): base ("EQEQ", "==") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new EqeqTokenElement(this);
      }
    }
    private class EqeqTokenElement : FixedTokenElement
    {
      public EqeqTokenElement(EqeqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType EQEQ = new EqeqNodeType();
    #endregion
    #region LE
    private class LeNodeType : FixedTokenNodeType
    {
      public LeNodeType(): base ("LE", "<=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LeTokenElement(this);
      }
    }
    private class LeTokenElement : FixedTokenElement
    {
      public LeTokenElement(LeNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LE = new LeNodeType();
    #endregion
    #region GE
    private class GeNodeType : FixedTokenNodeType
    {
      public GeNodeType(): base ("GE", ">=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new GeTokenElement(this);
      }
    }
    private class GeTokenElement : FixedTokenElement
    {
      public GeTokenElement(GeNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType GE = new GeNodeType();
    #endregion
    #region NE
    private class NeNodeType : FixedTokenNodeType
    {
      public NeNodeType(): base ("NE", "!=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new NeTokenElement(this);
      }
    }
    private class NeTokenElement : FixedTokenElement
    {
      public NeTokenElement(NeNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType NE = new NeNodeType();
    #endregion
    #region ANDAND
    private class AndandNodeType : FixedTokenNodeType
    {
      public AndandNodeType(): base ("ANDAND", "&&") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AndandTokenElement(this);
      }
    }
    private class AndandTokenElement : FixedTokenElement
    {
      public AndandTokenElement(AndandNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType ANDAND = new AndandNodeType();
    #endregion
    #region OROR
    private class OrorNodeType : FixedTokenNodeType
    {
      public OrorNodeType(): base ("OROR", "||") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new OrorTokenElement(this);
      }
    }
    private class OrorTokenElement : FixedTokenElement
    {
      public OrorTokenElement(OrorNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType OROR = new OrorNodeType();
    #endregion
    #region PLUSPLUS
    private class PlusplusNodeType : FixedTokenNodeType
    {
      public PlusplusNodeType(): base ("PLUSPLUS", "++") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new PlusplusTokenElement(this);
      }
    }
    private class PlusplusTokenElement : FixedTokenElement
    {
      public PlusplusTokenElement(PlusplusNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType PLUSPLUS = new PlusplusNodeType();
    #endregion
    #region MINUSMINUS
    private class MinusminusNodeType : FixedTokenNodeType
    {
      public MinusminusNodeType(): base ("MINUSMINUS", "--") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new MinusminusTokenElement(this);
      }
    }
    private class MinusminusTokenElement : FixedTokenElement
    {
      public MinusminusTokenElement(MinusminusNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType MINUSMINUS = new MinusminusNodeType();
    #endregion
    #region LTLT
    private class LtltNodeType : FixedTokenNodeType
    {
      public LtltNodeType(): base ("LTLT", "<<") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LtltTokenElement(this);
      }
    }
    private class LtltTokenElement : FixedTokenElement
    {
      public LtltTokenElement(LtltNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LTLT = new LtltNodeType();
    #endregion
    #region GTGT
    private class GtgtNodeType : FixedTokenNodeType
    {
      public GtgtNodeType(): base ("GTGT", ">>") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new GtgtTokenElement(this);
      }
    }
    private class GtgtTokenElement : FixedTokenElement
    {
      public GtgtTokenElement(GtgtNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType GTGT = new GtgtNodeType();
    #endregion
    #region PLUSEQ
    private class PluseqNodeType : FixedTokenNodeType
    {
      public PluseqNodeType(): base ("PLUSEQ", "+=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new PluseqTokenElement(this);
      }
    }
    private class PluseqTokenElement : FixedTokenElement
    {
      public PluseqTokenElement(PluseqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType PLUSEQ = new PluseqNodeType();
    #endregion
    #region MINUSEQ
    private class MinuseqNodeType : FixedTokenNodeType
    {
      public MinuseqNodeType(): base ("MINUSEQ", "-=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new MinuseqTokenElement(this);
      }
    }
    private class MinuseqTokenElement : FixedTokenElement
    {
      public MinuseqTokenElement(MinuseqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType MINUSEQ = new MinuseqNodeType();
    #endregion
    #region ASTERISKEQ
    private class AsteriskeqNodeType : FixedTokenNodeType
    {
      public AsteriskeqNodeType(): base ("ASTERISKEQ", "*=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AsteriskeqTokenElement(this);
      }
    }
    private class AsteriskeqTokenElement : FixedTokenElement
    {
      public AsteriskeqTokenElement(AsteriskeqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType ASTERISKEQ = new AsteriskeqNodeType();
    #endregion
    #region DIVEQ
    private class DiveqNodeType : FixedTokenNodeType
    {
      public DiveqNodeType(): base ("DIVEQ", "/=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new DiveqTokenElement(this);
      }
    }
    private class DiveqTokenElement : FixedTokenElement
    {
      public DiveqTokenElement(DiveqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType DIVEQ = new DiveqNodeType();
    #endregion
    #region ANDEQ
    private class AndeqNodeType : FixedTokenNodeType
    {
      public AndeqNodeType(): base ("ANDEQ", "&=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new AndeqTokenElement(this);
      }
    }
    private class AndeqTokenElement : FixedTokenElement
    {
      public AndeqTokenElement(AndeqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType ANDEQ = new AndeqNodeType();
    #endregion
    #region OREQ
    private class OreqNodeType : FixedTokenNodeType
    {
      public OreqNodeType(): base ("OREQ", "|=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new OreqTokenElement(this);
      }
    }
    private class OreqTokenElement : FixedTokenElement
    {
      public OreqTokenElement(OreqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType OREQ = new OreqNodeType();
    #endregion
    #region XOREQ
    private class XoreqNodeType : FixedTokenNodeType
    {
      public XoreqNodeType(): base ("XOREQ", "^=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new XoreqTokenElement(this);
      }
    }
    private class XoreqTokenElement : FixedTokenElement
    {
      public XoreqTokenElement(XoreqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType XOREQ = new XoreqNodeType();
    #endregion
    #region PERCEQ
    private class PerceqNodeType : FixedTokenNodeType
    {
      public PerceqNodeType(): base ("PERCEQ", "%=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new PerceqTokenElement(this);
      }
    }
    private class PerceqTokenElement : FixedTokenElement
    {
      public PerceqTokenElement(PerceqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType PERCEQ = new PerceqNodeType();
    #endregion
    #region LTLTEQ
    private class LtlteqNodeType : FixedTokenNodeType
    {
      public LtlteqNodeType(): base ("LTLTEQ", "<<=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LtlteqTokenElement(this);
      }
    }
    private class LtlteqTokenElement : FixedTokenElement
    {
      public LtlteqTokenElement(LtlteqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LTLTEQ = new LtlteqNodeType();
    #endregion
    #region GTGTEQ
    private class GtgteqNodeType : FixedTokenNodeType
    {
      public GtgteqNodeType(): base ("GTGTEQ", ">>=") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new GtgteqTokenElement(this);
      }
    }
    private class GtgteqTokenElement : FixedTokenElement
    {
      public GtgteqTokenElement(GtgteqNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType GTGTEQ = new GtgteqNodeType();
    #endregion
    #region LAMBDA_ARROW
    private class LambdaArrowNodeType : FixedTokenNodeType
    {
      public LambdaArrowNodeType(): base ("LAMBDA_ARROW", "=>") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new LambdaArrowTokenElement(this);
      }
    }
    private class LambdaArrowTokenElement : FixedTokenElement
    {
      public LambdaArrowTokenElement(LambdaArrowNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType LAMBDA_ARROW = new LambdaArrowNodeType();
    #endregion
    #region DOUBLE_COLON
    private class DoubleColonNodeType : FixedTokenNodeType
    {
      public DoubleColonNodeType(): base ("DOUBLE_COLON", "::") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new DoubleColonTokenElement(this);
      }
    }
    private class DoubleColonTokenElement : FixedTokenElement
    {
      public DoubleColonTokenElement(DoubleColonNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType DOUBLE_COLON = new DoubleColonNodeType();
    #endregion
    #region DOUBLE_QUEST
    private class DoubleQuestNodeType : FixedTokenNodeType
    {
      public DoubleQuestNodeType(): base ("DOUBLE_QUEST", "??") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new DoubleQuestTokenElement(this);
      }
    }
    private class DoubleQuestTokenElement : FixedTokenElement
    {
      public DoubleQuestTokenElement(DoubleQuestNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType DOUBLE_QUEST = new DoubleQuestNodeType();
    #endregion
    #region ARROW
    private class ArrowNodeType : FixedTokenNodeType
    {
      public ArrowNodeType(): base ("ARROW", "->") {}
      public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
      {
        return new ArrowTokenElement(this);
      }
    }
    private class ArrowTokenElement : FixedTokenElement
    {
      public ArrowTokenElement(ArrowNodeType tokenNodeType) : base(tokenNodeType) { }
    }
    public static readonly TokenNodeType ARROW = new ArrowNodeType();
    #endregion

  }
}
