using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeAsyncTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnitAsync_00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<Task> funcAsync = null!;
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeThenToUnitAsync());

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Obsolete]
    [Test]
    public async Task InvokeThenToUnitAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc(Task.CompletedTask);
        var funcAsync = new Func<Task>(mockFuncAsync.Object.Invoke);

        var actual = await funcAsync.InvokeThenToUnitAsync();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
