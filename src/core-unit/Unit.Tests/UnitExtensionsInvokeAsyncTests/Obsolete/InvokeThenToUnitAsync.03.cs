﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeAsyncTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnitAsync_03_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3));
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitAsync_03_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, Task>(Task.CompletedTask);
        var funcAsync = new Func<StructType, RefType?, string, Task>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;

        var actual = await funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(f => f.Invoke(arg1, arg2, arg3), Times.Once);
    }
}
