﻿using System;
using JetBrains.ReSharper.Refactorings.Test;
using NUnit.Framework;

namespace LexPluginTest.Refactoring.Rename
{
  [Category("PSI")]
  class LexRenameTest : RenameTestBase
  {
    protected override String RelativeTestDataPath
    {
      get { return @"refactoring\rename"; }
    }

    [Test]
    public void test001()
    {
      DoTestFiles(new[] { "test001.lex" });
    }

    [Test]
    public void test002()
    {
      DoTestFiles(new[] { "test002.lex" });
    }
  }
}