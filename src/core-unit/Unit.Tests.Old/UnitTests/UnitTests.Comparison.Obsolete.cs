using System;
using System.Collections.Generic;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Obsolete]
    [Test]
    public void CompareTo_Obj_Unit_ExpectZero()
    {
        object? obj = default(Unit);

        var actual = Unit.Value.CompareTo(obj);
        Assert.That(actual, Is.Zero);
    }

    [Obsolete]
    [Test]
    public void CompareTo_Obj_Null_ExpectGreaterThanZero_ExpectOne()
    {
        object? obj = null;

        var actual = Unit.Value.CompareTo(obj);

        Assert.That(actual, Is.Positive);
        Assert.That(actual, Is.EqualTo(1));
    }

    [Obsolete]
    [Test]
    [TestCaseSource(nameof(CompareTo_Obj_NotUnit_ExpectArgumentException_TestCases))]
    public void CompareTo_Obj_NotUnit_ExpectArgumentException(object obj)
    {
        var ex = Assert.Throws<ArgumentException>(() => _ = Unit.Value.CompareTo(obj))!;

        Assert.That(ex.ParamName, Is.EqualTo("obj"));

        var containsExpectedMessage = ex.Message.Contains("Object must be of type Unit.", StringComparison.Ordinal);
        Assert.That(containsExpectedMessage, Is.True);
    }

    private static IEnumerable<object> CompareTo_Obj_NotUnit_ExpectArgumentException_TestCases()
    {
        yield return new object();
        yield return PlusFifteen;
        yield return PlusFifteenIdRefType;
        yield return SomeTextStructType;
        yield return Array.Empty<Unit>();
    }
}
