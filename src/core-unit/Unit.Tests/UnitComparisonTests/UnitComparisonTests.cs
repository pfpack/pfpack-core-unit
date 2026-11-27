using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitComparisonTests
{
    [Fact]
    public static void ComparisonOperator_LessThanOrEqualTo_ExpectTrue()
    {
        Unit left = default;
        Unit right = default;
        var actual = left <= right;
        Assert.True(actual);
    }

    [Fact]
    public static void ComparisonOperator_GreaterThanOrEqualTo_ExpectTrue()
    {
        Unit left = default;
        Unit right = default;
        var actual = left >= right;
        Assert.True(actual);
    }

    [Fact]
    public static void ComparisonOperator_LessThan_ExpectFalse()
    {
        Unit left = default;
        Unit right = default;
        var actual = left < right;
        Assert.False(actual);
    }

    [Fact]
    public static void ComparisonOperator_GreaterThan_ExpectFalse()
    {
        Unit left = default;
        Unit right = default;
        var actual = left > right;
        Assert.False(actual);
    }

    [Fact]
    public static void CompareStatic_ExpectZero()
    {
        Unit left = default;
        Unit right = default;
        var actual = Unit.Compare(left, right);
        Assert.StrictEqual(0, actual);
    }

    [Fact]
    public static void CompareTo_ExpectZero()
    {
        Unit source = default;
        Unit other = default;
        var actual = source.CompareTo(other);
        Assert.StrictEqual(0, actual);
    }
}
