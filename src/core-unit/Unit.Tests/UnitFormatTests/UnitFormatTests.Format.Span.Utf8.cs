using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsEqual_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsEqual_ExpectSuccessResult(
			InnerFormatToSpanUtf8,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsGreater_ExpectSuccessResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsGreater_ExpectSuccessResult(
			InnerFormatToSpanUtf8,
			testCase);

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsLess_ExpectFailureResult((string? Format, string Expected) testCase)
		=>
		Inner_FormatToSpanUtf8_DestLengthIsLess_ExpectFailureResult(
			InnerFormatToSpanUtf8,
			testCase);

	private static (bool Result, int BytesWritten) InnerFormatToSpanUtf8(Span<byte> destination, ReadOnlySpan<char> format)
	{
		var result = Unit.TryFormat(destination, out var bytesWritten, format);
		return (result, bytesWritten);
	}
}
