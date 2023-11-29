using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using System.Threading.Tasks;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeAsyncTests
{
    [Test]
    public void InvokeAsync_02_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, Task> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = Unit.InvokeAsync(funcAsync, arg1, arg2));
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeAsync_02_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, Task>(Task.CompletedTask);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;

        var actual = await Unit.InvokeAsync(mockFuncAsync.Object.Invoke, arg1, arg2);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(arg1, arg2), Times.Once);
    }
}
