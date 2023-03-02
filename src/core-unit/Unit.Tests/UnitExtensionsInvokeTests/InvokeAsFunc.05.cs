﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using PrimeFuncPack.UnitTest.Moq;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Test]
    public void InvokeAsFunc_05_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType, RefType, string, int, object> action = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusTwentyOne;
        var arg5 = new { Value = PlusOneHundredPointFive };

        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeAsFunc(arg1, arg2, arg3, arg4, arg5));
        Assert.AreEqual("action", ex!.ParamName);
    }

    [Test]
    public void InvokeAsFunc_05_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction<StructType, RefType?, string, int, object?>();
        var action = new Action<StructType, RefType?, string, int, object?>(mockAction.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusTwentyOne;
        var arg5 = new { Value = PlusOneHundredPointFive };

        var actual = action.InvokeAsFunc(arg1, arg2, arg3, arg4, arg5);

        Assert.AreEqual(Unit.Value, actual);
        mockAction.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5), Times.Once);
    }
}
