﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using PrimeFuncPack.UnitTest.Moq;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvoketValueAsyncTests
{
    [Test]
    public void InvokeAsFuncValueAsync_05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncValueAsync(arg1, arg2, arg3, arg4, arg5).AsTask());
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeAsFuncValueAsync_05_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var actual = await funcAsync.InvokeAsFuncValueAsync(arg1, arg2, arg3, arg4, arg5);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5), Times.Once);
    }
}
