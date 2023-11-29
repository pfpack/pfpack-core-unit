using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Test]
    public void InvokeAsFunc_04_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType, RefType, string, int> action = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusTwentyOne;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeAsFunc(arg1, arg2, arg3, arg4));
        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void InvokeAsFunc_04_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction<StructType, RefType?, string, int>();
        var action = new Action<StructType, RefType?, string, int>(mockAction.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusTwentyOne;

        var actual = action.InvokeAsFunc(arg1, arg2, arg3, arg4);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(arg1, arg2, arg3, arg4), Times.Once);
    }
}
