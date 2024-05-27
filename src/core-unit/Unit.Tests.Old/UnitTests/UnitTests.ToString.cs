using System;

namespace PrimeFuncPack.Core.Tests;

    partial class UnitTests
    {
        [Test]
        public void ToString_ExpectUnitValueString()
        {
            var source = default(Unit);
            var actual = source.ToString();

            const string expected = "Unit:()";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
