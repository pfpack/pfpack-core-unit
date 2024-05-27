using Moq;
using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Test]
    public void InvokeAsFunc_00_ActionIsNull_ExpectArgumentNullException()
    {
        Action action = null!;
        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeAsFunc());

        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void InvokeAsFunc_00_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction();
        var action = new Action(mockAction.Object.Invoke);

        var actual = action.InvokeAsFunc();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(), Times.Once);
    }
}
