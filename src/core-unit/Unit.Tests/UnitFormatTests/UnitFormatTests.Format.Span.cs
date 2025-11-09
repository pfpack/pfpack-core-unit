using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpan,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpan,
			format,
			expected);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases_WithoutEmptyResult))]
	public static void FormatToSpan_DestLengthIsLess_ExpectFailureResult(string? format, string expected)
		=>
		Inner_FormatToSpan_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpan,
			format,
			expected);

	private static (bool Result, int CharsWritten) InnerFormatToSpan(Span<char> destination, ReadOnlySpan<char> format)
	{
		var result = Unit.TryFormat(destination, out var charsWritten, format);
		return (result, charsWritten);
	}
}
