using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8Explicit_DestLengthIsEqual_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpanUtf8Explicit,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8Explicit_DestLengthIsGreater_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpanUtf8Explicit,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8Explicit_DestLengthIsLess_ExpectFailureResult(string? format, string expected)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpanUtf8Explicit,
			format,
			expected);

	private static (bool Result, int BytesWritten) InnerFormatToSpanUtf8Explicit(Span<byte> destination, ReadOnlySpan<char> format)
	{
		var source = (IUtf8SpanFormattable)default(Unit);
		var result = source.TryFormat(destination, out var bytesWritten, format, null);
		return (result, bytesWritten);
	}
}
