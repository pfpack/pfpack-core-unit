using Moq;
using NUnit.Framework;
using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnit_00_ActionIsNull_ExpectArgumentNullException()
    {
        Action action = null!;
        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeThenToUnit());

        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Obsolete]
    [Test]
    public void InvokeThenToUnit_00_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction();
        var action = new Action(mockAction.Object.Invoke);

        var actual = action.InvokeThenToUnit();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(), Times.Once);
    }
}
