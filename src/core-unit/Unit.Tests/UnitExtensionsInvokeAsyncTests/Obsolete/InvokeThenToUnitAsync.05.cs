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
    public void InvokeThenToUnitAsync_05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5));
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitAsync_05_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, Task>(Task.CompletedTask);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, Task>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var actual = await funcAsync.InvokeThenToUnitAsync(arg1, arg2, arg3, arg4, arg5);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5), Times.Once);
    }
}
