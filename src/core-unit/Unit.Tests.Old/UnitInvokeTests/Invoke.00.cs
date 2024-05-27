using Moq;
using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeTests
{
    [Test]
    public void Invoke_00_ActionIsNull_ExpectArgumentNullException()
    {
        Action action = null!;
        var ex = Assert.Throws<ArgumentNullException>(() => _ = Unit.Invoke(action));

        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void Invoke_00_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction();
        var actual = Unit.Invoke(mockAction.Object.Invoke);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(), Times.Once);
    }
}
