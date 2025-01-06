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
        Assert.That(actual, Is.Zero);
    }

    [Test]
    public void Compare_Static_ExpectZero()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = Unit.Compare(left, right);
        Assert.That(actual, Is.Zero);
    }

    [Test]
    public void Compare_Operator_LessThanOrEqualTo_ExpectTrue()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left <= right;
        Assert.That(actual, Is.True);
    }

    [Test]
    public void Compare_Operator_GreaterThanOrEqualTo_ExpectTrue()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left >= right;
        Assert.That(actual, Is.True);
    }

    [Test]
    public void Compare_Operator_LessThan_ExpectFalse()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left < right;
        Assert.That(actual, Is.False);
    }

    [Test]
    public void Compare_Operator_GreaterThan_ExpectFalse()
    {
        var left = Unit.Value;
        var right = default(Unit);

        var actual = left > right;
        Assert.That(actual, Is.False);
    }
}
