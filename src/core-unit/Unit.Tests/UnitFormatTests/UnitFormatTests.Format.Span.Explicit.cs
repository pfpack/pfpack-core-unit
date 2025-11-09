using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsEqual_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpanExplicit,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsGreater_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpanExplicit,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanExplicit_DestLengthIsLess_ExpectFailureResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpan_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpanExplicit,
			testCase);

	private static (bool Result, int CharsWritten) InnerFormatToSpanExplicit(Span<char> destination, ReadOnlySpan<char> format)
	{
		var source = (ISpanFormattable)default(Unit);
		var result = source.TryFormat(destination, out var charsWritten, format, null);
		return (result, charsWritten);
	}
}
