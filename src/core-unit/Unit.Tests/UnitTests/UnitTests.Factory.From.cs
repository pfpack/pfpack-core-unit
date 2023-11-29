using NUnit.Framework;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void From_ExpectValue(
        bool isResultNull)
    {
        var result = isResultNull ? null : MinusFifteenIdRefType;
        var actual = Unit.From(result);

        Assert.That(actual, Is.EqualTo(Unit.Value));
    }
}
