using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsEqual_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpanExplicit,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsGreater_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpanExplicit,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsLess_ExpectFailureResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpanExplicit,
			format,
			expected);

	private static (bool Result, int CharsWritten) InnerFormatToSpanExplicit(Span<char> destination, ReadOnlySpan<char> format)
	{
		var source = (ISpanFormattable)default(Unit);
		var result = source.TryFormat(destination, out var charsWritten, format, null);
		return (result, charsWritten);
	}
}
