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
    public void InvokeAsFuncValueAsync_09_FuncIsNull_ExpectArgumentNullException()
    {
        Func<StructType, RefType, string, int, object, DateTime, StructType?, decimal, RefType, ValueTask> funcAsync = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = NullTextStructType;
        var arg8 = MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;

        var ex = Assert.ThrowsAsync<ArgumentNullException>(() => _ = funcAsync.InvokeAsFuncValueAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9).AsTask());
        Assert.That(ex!.ParamName, Is.EqualTo("funcAsync"));
    }

    [Test]
    public async Task InvokeAsFuncValueAsync_09_ExpectCallFuncOnce()
    {
        var mockFuncAsync = MockFuncFactory.CreateMockFunc<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, ValueTask>(default);
        var funcAsync = new Func<StructType, RefType?, string, int, object?, DateTime, StructType?, decimal?, RefType, ValueTask>(mockFuncAsync.Object.Invoke);

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = (StructType?)null;
        var arg8 = (decimal?)MinusSeventyFivePointSeven;
        var arg9 = ZeroIdRefType;

        var actual = await funcAsync.InvokeAsFuncValueAsync(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockFuncAsync.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), Times.Once);
    }
}
