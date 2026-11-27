using System.Text;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatUnexpectedTests
{
    [Fact]
    public static void Format_ExpectFailure()
        =>
        AssertUnexpectedFormat(format => UnitInstance.Format(
            format));

    [Fact]
    public static void FormatToUtf8_ExpectFailure()
       =>
       AssertUnexpectedFormat(format => UnitInstance.FormatToUtf8(
           format));

    [Fact]
    public static void TryFormat_ExpectFailure()
       =>
       AssertUnexpectedFormat(format => UnitInstance.TryFormat(
           new char[format.Length],
           out _,
           format));

    [Fact]
    public static void TryFormatToUtf8_ExpectFailure()
       =>
       AssertUnexpectedFormat(format => UnitInstance.TryFormat(
           new byte[Encoding.UTF8.GetByteCount(format)],
           out _,
           format));
}
