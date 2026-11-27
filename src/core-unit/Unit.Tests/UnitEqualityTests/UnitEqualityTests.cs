using System;
using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitEqualityTests
{
    [Fact]
    public static void EqualityOperator_ExpectTrue()
    {
        Unit left = default;
        Unit right = default;
        var actual = left == right;
        Assert.True(actual);
    }

    [Fact]
    public static void InequalityOperator_ExpectFalse()
    {
        Unit left = default;
        Unit right = default;
        var actual = left != right;
        Assert.False(actual);
    }

    [Fact]
    public static void EqualsStatic_ExpectTrue()
    {
        Unit left = default;
        Unit right = default;
        var actual = Unit.Equals(left, right);
        Assert.True(actual);
    }

    [Fact]
    public static void Equals_ExpectTrue()
    {
        Unit source = default;
        Unit other = default;
        var actual = source.Equals(other);
        Assert.True(actual);
    }

    [Fact]
    public static void EqualsObject_ObjIsUnit_ExpectTrue()
    {
        Unit source = default;
        object? obj = source;
        var actual = source.Equals(obj);
        Assert.True(actual);
    }

    [Theory]
    [MemberData(nameof(EqualsObject_NotUnitCases))]
    public static void EqualsObject_ObjIsNotUnit_ExpectFalse(object? obj)
    {
        Unit source = default;
        var actual = source.Equals(obj);
        Assert.False(actual);
    }

    [Fact]
    public static void GetHashCode_ExpectConsistent()
    {
        Unit first = default;
        Unit second = default;
        var firstActual = first.GetHashCode();
        var secondActual = second.GetHashCode();
        Assert.True(firstActual == secondActual);
    }

    [Fact]
    public static void GetHashCode_ExpectValueBasedOnEqualityContract()
    {
        var expected = HashCode.Combine(
            EqualityComparer<Type>.Default.GetHashCode(typeof(Unit)));

        Unit source = default;
        var actual = source.GetHashCode();

        Assert.StrictEqual(expected, actual);
    }

    public static TheoryData<object?> EqualsObject_NotUnitCases
        =>
        [(object?)null, new object(), 0, 1, "", "1"];
}
