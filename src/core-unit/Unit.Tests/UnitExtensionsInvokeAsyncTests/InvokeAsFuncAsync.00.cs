using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeAsyncTests
{
    [Test]
    public void InvokeAsFuncAsync_00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<Task> funcAsync = null!;
        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncAsync());

        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeAsFuncAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc(Task.CompletedTask);
        var funcAsync = new Func<Task>(mockFuncAsync.Object.Invoke);

        var actual = await funcAsync.InvokeAsFuncAsync();

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
