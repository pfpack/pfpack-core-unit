﻿using Moq;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Test]
    public void InvokeAsFunc_02_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType, RefType> action = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeAsFunc(arg1, arg2));
        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void InvokeAsFunc_02_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction<StructType, RefType?>();
        var action = new Action<StructType, RefType?>(mockAction.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;

        var actual = action.InvokeAsFunc(arg1, arg2);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(arg1, arg2), Times.Once);
    }
}
