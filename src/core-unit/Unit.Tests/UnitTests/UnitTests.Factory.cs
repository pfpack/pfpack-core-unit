using NUnit.Framework;
using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitTests
{
    [Test]
    public void Value_ExpectDefault()
        =>
        Assert.That(Unit.Value, Is.EqualTo(default(Unit)));

    [Test]
    public void Get_ExpectDefault()
        =>
        Assert.That(Unit.Get(), Is.EqualTo(default(Unit)));

    [Test]
    public void Get_ExpectValue()
        =>
        Assert.That(Unit.Get(), Is.EqualTo(Unit.Value));

    [Test]
    public void New_ExpectDefault()
        =>
        Assert.That(new Unit(), Is.EqualTo(default(Unit)));

    [Test]
    public void New_ExpectValue()
        =>
        Assert.That(new Unit(), Is.EqualTo(Unit.Value));
}
