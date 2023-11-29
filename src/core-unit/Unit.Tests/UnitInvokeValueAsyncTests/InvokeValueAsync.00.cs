using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeValueAsyncTests
{
    [Test]
    public void InvokeValueAsync_00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<ValueTask> funcAsync = null!;
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = Unit.InvokeValueAsync(funcAsync).AsTask());

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeValueAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<ValueTask>(default);
        var actual = await Unit.InvokeValueAsync(mockFuncAsync.Object.Invoke);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
