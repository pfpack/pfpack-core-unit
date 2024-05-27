﻿using Moq;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeAsyncTests
{
    [Test]
    public void InvokeAsync_03_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = Unit.InvokeAsync(funcAsync, arg1, arg2, arg3));
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeAsync_03_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, Task>(Task.CompletedTask);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;

        var actual = await Unit.InvokeAsync(mockFuncAsync.Object.Invoke, arg1, arg2, arg3);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(arg1, arg2, arg3), Times.Once);
    }
}