using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvoketValueAsyncTests
{
    [Test]
    public void InvokeAsFuncValueAsync_00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<ValueTask> funcAsync = null!;
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncValueAsync().AsTask());

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeAsFuncValueAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<ValueTask>(default);
        var funcAsync = new Func<ValueTask>(mockFuncAsync.Object.Invoke);

        var actual = await funcAsync.InvokeAsFuncValueAsync();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
