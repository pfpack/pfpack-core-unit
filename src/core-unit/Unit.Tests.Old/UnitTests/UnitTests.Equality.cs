using NUnit.Framework;
using System;
using System.Collections.Generic;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Test]
    public void StaticEquals_ExpectTrue()
    {
        var valueA = new Unit();
        var valueB = Unit.Value;

        var actual = Unit.Equals(valueA, valueB);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void EqualityOperator_ExpectTrue()
    {
        var valueA = default(Unit);
        var valueB = Unit.Value;

        var actual = valueA == valueB;
        Assert.That(actual, Is.True);
    }

    [Test]
    public void InequalityOperator_ExpectFalse()
    {
        var valueA = default(Unit);
        var valueB = Unit.Value;

        var actual = valueA != valueB;
        Assert.That(actual, Is.False);
    }

    [Test]
    public void Equals_ExpectTrue()
    {
        var source = new Unit();
        var other = Unit.Value;

        var actual = source.Equals(other);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void EqualsWithObject_ObjIsNull_ExpectFalse()
    {
        var source = Unit.Value;
        object? obj = null;

        var actual = source.Equals(obj);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void EqualsWithObject_ObjIsNotUnit_ExpectFalse()
    {
        var source = Unit.Value;
        object? obj = SomeTextStructType;

        var actual = source.Equals(obj);
        Assert.That(actual, Is.False);
    }

    [Test]
    public void EqualsWithObject_ObjIsUnit_ExpectTrue()
    {
        var source = Unit.Value;
        object? obj = default(Unit);

        var actual = source.Equals(obj);
        Assert.That(actual, Is.True);
    }

    [Test]
    public void GetHashCode_ExpectCombinedFromEqualityContract()
    {
        var source = Unit.Value;
        var actual = source.GetHashCode();

        var expected = HashCode.Combine(EqualityComparer<Type>.Default.GetHashCode(typeof(Unit)));
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void GetHashCode_ExpectAreEqual()
    {
        var hashCode1 = default(Unit).GetHashCode();
        var hashCode2 = Unit.Value.GetHashCode();

        Assert.That(hashCode2, Is.EqualTo(hashCode1));
    }
}
