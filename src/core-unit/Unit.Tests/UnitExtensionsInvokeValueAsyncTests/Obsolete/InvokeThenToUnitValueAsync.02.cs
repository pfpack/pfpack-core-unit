using Moq;
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
    public void InvokeThenToUnitValueAsync_02_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitValueAsync(arg1, arg2).AsTask());
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitValueAsync_02_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;

        var actual = await funcAsync.InvokeThenToUnitValueAsync(arg1, arg2);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(arg1, arg2), Times.Once);
    }
}
