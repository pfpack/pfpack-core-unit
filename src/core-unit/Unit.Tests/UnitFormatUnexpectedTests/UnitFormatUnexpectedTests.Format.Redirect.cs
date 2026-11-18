using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatUnexpectedTests
{
    [Fact]
    [Obsolete("Test of Redirect from the legacy pattern to the new method.")]
    public static void ToStringObsolete_ExpectFailure()
        =>
        AssertUnexpectedFormat(format => UnitInstance.ToString(format));
}
