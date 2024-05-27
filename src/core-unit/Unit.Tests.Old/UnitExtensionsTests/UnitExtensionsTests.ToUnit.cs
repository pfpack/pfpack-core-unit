using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsTests
{
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ToUnit_ExpectUnitValue(
        bool isSourceNull)
    {
        StructType? source = isSourceNull ? null : SomeTextStructType;
        var actual = source.ToUnit();

        Assert.That(actual, Is.EqualTo(Unit.Value));
    }
}
