using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsEqual_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpan,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsGreater_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpan,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsLess_ExpectFailureResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpan,
			testCase);

	private static (bool Result, int CharsWritten) InnerFormatToSpan(Span<char> destination, ReadOnlySpan<char> format)
	{
		var result = Unit.TryFormat(destination, out var charsWritten, format);
		return (result, charsWritten);
	}
}
