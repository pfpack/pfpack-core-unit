using NUnit.Framework;
using System;
using System.Collections.Generic;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Test]
    public void CompareTo_Typed_ExpectZero()
    {
        var other = default(Unit);

        var actual = Unit.Value.CompareTo(other);
        Assert.Zero(actual);
    }

    [Test]
    public void CompareTo_Obj_Unit_ExpectZero()
    {
        object? obj = default(Unit);

        var actual = Unit.Value.CompareTo(obj);
        Assert.Zero(actual);
    }

    [Test]
    public void CompareTo_Obj_Null_ExpectGreaterThanZero_ExpectOne()
    {
        object? obj = null;

        var actual = Unit.Value.CompareTo(obj);

        Assert.True(actual > 0);
        Assert.AreEqual(1, actual);
    }

    [Test]
    [TestCaseSource(nameof(CompareTo_Obj_NotUnit_ExpectArgumentException_TestCases))]
    public void CompareTo_Obj_NotUnit_ExpectArgumentException(object obj)
    {
        var ex = Assert.Throws<ArgumentException>(() => _ = Unit.Value.CompareTo(obj))!;

        Assert.AreEqual("obj", ex.ParamName);

        var containsExpectedMessage = ex.Message.Contains("The object is not the Unit.", StringComparison.Ordinal);
        Assert.True(containsExpectedMessage);
    }

    [Test]
    public void Compare_Static_ExpectZero()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = Unit.Compare(left, right);
        Assert.Zero(actual);
    }

    [Test]
    public void Compare_Operator_LessThanOrEqualTo_ExpectTrue()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left <= right;
        Assert.True(actual);
    }

    [Test]
    public void Compare_Operator_GreaterThanOrEqualTo_ExpectTrue()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left >= right;
        Assert.True(actual);
    }

    [Test]
    public void Compare_Operator_LessThan_ExpectFalse()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left < right;
        Assert.False(actual);
    }

    [Test]
    public void Compare_Operator_GreaterThan_ExpectFalse()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left > right;
        Assert.False(actual);
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
