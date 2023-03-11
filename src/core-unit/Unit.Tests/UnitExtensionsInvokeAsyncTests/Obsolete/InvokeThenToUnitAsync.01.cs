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
    public void InvokeThenToUnitAsync_01_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, Task> funcAsync = null!;
        var arg = SomeTextStructType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync(arg));

        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Obsolete]
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task InvokeThenToUnitAsync_01_ExpectCallFuncOnce(
        bool isArgNull)
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<RefType?, Task>(Task.CompletedTask);
        var funcAsync = new Func<RefType?, Task>(mockFuncAsync.Object.Invoke);

        var arg = isArgNull ? null : MinusFifteenIdRefType;
        var actual = await funcAsync.InvokeThenToUnitAsync(arg);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(f => f.Invoke(arg), Times.Once);
    }
}
