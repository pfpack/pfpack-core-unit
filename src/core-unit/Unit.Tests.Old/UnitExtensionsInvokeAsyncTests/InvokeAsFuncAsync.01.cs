﻿using Moq;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeAsyncTests
{
    [Test]
    public void InvokeAsFuncAsync_01_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, Task> funcAsync = null!;
        var arg = SomeTextStructType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncAsync(arg));

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public async Task InvokeAsFuncAsync_01_ExpectCallFuncOnce(
        bool isArgNull)
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<RefType?, Task>(Task.CompletedTask);
        var funcAsync = new Func<RefType?, Task>(mockFuncAsync.Object.Invoke);

        var arg = isArgNull ? null : MinusFifteenIdRefType;
        var actual = await funcAsync.InvokeAsFuncAsync(arg);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(arg), Times.Once);
    }
}
