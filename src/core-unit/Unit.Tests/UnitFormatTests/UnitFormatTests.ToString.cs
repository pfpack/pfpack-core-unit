using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Fact]
    public static void ToString_ExpectGeneralResult()
    {
        const string expected = "Unit:()";
        var actual = UnitInstance.ToString();
        Assert.Equal(expected, actual);
    }
}
