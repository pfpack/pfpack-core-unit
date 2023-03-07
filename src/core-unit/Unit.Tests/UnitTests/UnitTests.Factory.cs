using NUnit.Framework;
using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Test]
    public void Value_ExpectDefault()
        =>
        Assert.AreEqual(default(Unit), Unit.Value);

    [Test]
    public void Get_ExpectDefault()
        =>
        Assert.AreEqual(default(Unit), Unit.Get());

    [Test]
    public void Get_ExpectValue()
        =>
        Assert.AreEqual(Unit.Value, Unit.Get());

    [Test]
    public void New_ExpectDefault()
        =>
        Assert.AreEqual(default(Unit), new Unit());

    [Test]
    public void New_ExpectValue()
        =>
        Assert.AreEqual(Unit.Value, new Unit());
}
