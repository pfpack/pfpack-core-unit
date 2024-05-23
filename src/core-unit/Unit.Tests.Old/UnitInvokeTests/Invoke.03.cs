using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeTests
{
    [Test]
    public void Invoke_03_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType, RefType, string> action = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = Unit.Invoke(action, arg1, arg2, arg3));
        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void Invoke_03_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction<StructType, RefType?, string>();

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;

        var actual = Unit.Invoke(mockAction.Object.Invoke, arg1, arg2, arg3);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(arg1, arg2, arg3), Times.Once);
    }
}
