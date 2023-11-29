using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvoketValueAsyncTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnitValueAsync_00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<ValueTask> funcAsync = null!;
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitValueAsync().AsTask());

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitValueAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<ValueTask>(default);
        var funcAsync = new Func<ValueTask>(mockFuncAsync.Object.Invoke);

        var actual = await funcAsync.InvokeThenToUnitValueAsync();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
