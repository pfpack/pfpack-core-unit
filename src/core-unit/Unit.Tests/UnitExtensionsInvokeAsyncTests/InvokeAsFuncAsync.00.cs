using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest.Moq;
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

        Assert.AreEqual("funcAsync", ex!.ParamName);
    }

    [Test]
    public async Task InvokeAsFuncAsync_00_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc(Task.CompletedTask);
        var funcAsync = new Func<Task>(mockFuncAsync.Object.Invoke);

        var actual = await funcAsync.InvokeAsFuncAsync();

        Assert.AreEqual(Unit.Value, actual);
        mockFuncAsync.Verify(f => f.Invoke(), Times.Once);
    }
}
