using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeTests
{
    [Test]
    public void Invoke_01_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType> action = null!;
        var arg = SomeTextStructType;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = Unit.Invoke(action, arg));

        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void Invoke_01_ExpectCallActionOnce(
        bool isArgNull)
    {
        var mockAction = MockActionFactory.CreateMockAction<RefType?>();

        var arg = isArgNull ? null : MinusFifteenIdRefType;
        var actual = Unit.Invoke(mockAction.Object.Invoke, arg);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(arg), Times.Once);
    }
}
