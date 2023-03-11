using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvoketValueAsyncTests
{
    [Test]
    public void InvokeAsFuncValueAsync_02_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncValueAsync(arg1, arg2).AsTask());
        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeAsFuncValueAsync_02_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;

        var actual = await funcAsync.InvokeAsFuncValueAsync(arg1, arg2);

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(f => f.Invoke(arg1, arg2), Times.Once);
    }
}
