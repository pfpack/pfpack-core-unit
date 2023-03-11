﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeValueAsyncTests
{
    [Test]
    public void InvokeValueAsync_05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = Unit.InvokeValueAsync(funcAsync, arg1, arg2, arg3, arg4, arg5).AsTask());
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeValueAsync_05_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, ValueTask>(default);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var actual = await Unit.InvokeValueAsync(mockFuncAsync.Object.Invoke, arg1, arg2, arg3, arg4, arg5);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5), Times.Once);
    }
}
