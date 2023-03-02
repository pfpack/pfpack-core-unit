﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using PrimeFuncPack.UnitTest.Moq;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeAsyncTests
{
    [Test]
    public void InvokeThenToUnitAsync_06_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, DateTime, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5, arg6));
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeThenToUnitAsync_06_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, DateTime, Task>(Task.CompletedTask);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, DateTime, Task>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;

        var actual = await funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5, arg6);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5, arg6), Times.Once);
    }
}
