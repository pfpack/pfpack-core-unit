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
    public void InvokeThenToUnitValueAsync_05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitValueAsync(arg1, arg2, arg3, arg4, arg5).AsTask());
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitValueAsync_05_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };

        var actual = await funcAsync.InvokeThenToUnitValueAsync(arg1, arg2, arg3, arg4, arg5);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5), Times.Once);
    }
}
