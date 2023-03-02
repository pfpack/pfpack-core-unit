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
    public void InvokeThenToUnitAsync_09_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, DateTime, StructType?, decimal, RefType, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = NullTextStructType;
        var arg8 = MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeThenToUnitAsync_09_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, Task>(Task.CompletedTask);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, Task>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = (StructType?)null;
        var arg8 = (decimal?)MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;

        var actual = await funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), Times.Once);
    }
}
