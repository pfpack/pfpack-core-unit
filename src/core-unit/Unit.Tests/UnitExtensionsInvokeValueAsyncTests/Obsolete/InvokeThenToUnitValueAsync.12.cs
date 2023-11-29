﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvoketValueAsyncTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnitValueAsync_12_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, DateTime, StructType?, decimal, RefType, object, StructType, string, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = NullTextStructType;
        var arg8 = MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;
        var arg10 = new object();
        var arg11 = CustomStringStructType;
        var arg12 = CustomText;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitValueAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12).AsTask());
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitValueAsync_12_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, object, StructType, string, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, object, StructType, string, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = (StructType?)null;
        var arg8 = (decimal?)MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;
        var arg10 = new object();
        var arg11 = CustomStringStructType;
        var arg12 = CustomText;

        var actual = await funcAsync.InvokeThenToUnitValueAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12), Times.Once);
    }
}
