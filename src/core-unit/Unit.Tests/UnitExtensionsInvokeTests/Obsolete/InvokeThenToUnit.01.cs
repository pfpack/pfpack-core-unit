﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsInvokeTests
{
    [Obsolete]
    [Test]
    public void InvokeThenToUnit_01_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType> action = null!;
        var arg = SomeTextStructType;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = action.InvokeThenToUnit(arg));

        Assert.AreEqual("action", ex!.ParamName);
    }

    [Obsolete]
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void InvokeThenToUnit_01_ExpectCallActionOnce(
        bool isArgNull)
    {
        var mockAction = MockActionFactory.CreateMockAction<RefType?>();
        var action = new Action<RefType?>(mockAction.Object.Invoke);

        var arg = isArgNull ? null : PlusFifteenIdRefType;
        var actual = action.InvokeThenToUnit(arg);

        Assert.AreEqual(Unit.Value, actual);
        mockAction.Verify(a => a.Invoke(arg), Times.Once);
    }
}
