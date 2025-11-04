using System;
using System.Text;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsEqual_ExpectSuccessResult((string? Format, string Expected) testCase)
	{
		var (format, expected) = (testCase.Format, Encoding.UTF8.GetBytes(testCase.Expected));

		var destination = new byte[expected.Length];

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination);
	}

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsGreater_ExpectSuccessResult((string? Format, string Expected) testCase)
	{
		var (format, expected) = (testCase.Format, Encoding.UTF8.GetBytes(testCase.Expected));

		const int extraLength = 1;
		const byte filler = byte.MaxValue;

		var destination = new byte[expected.Length + extraLength];
		destination.AsSpan(start: expected.Length).Fill(filler);

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination[..expected.Length]);

		var expectedExtra = new byte[extraLength];
		expectedExtra.AsSpan().Fill(filler);
		Assert.Equal(expectedExtra, destination[expected.Length..]);
	}

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpanUtf8_DestLengthIsLess_ExpectFailureResult((string? Format, string Expected) testCase)
	{
		var (format, expectedLength) = (testCase.Format, Encoding.UTF8.GetBytes(testCase.Expected).Length);

		if (expectedLength == 0)
		{
			// Skip inapplicable case
			Assert.False(false);
			return;
		}

		const byte filler = byte.MaxValue;

		var destination = new byte[expectedLength - 1];
		destination.AsSpan().Fill(filler);

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.False(actualResult);
		Assert.Equal(0, actualCharsWritten);

		var expectedDestination = new byte[destination.Length];
		expectedDestination.AsSpan().Fill(filler);
		Assert.Equal(expectedDestination, destination);
	}
}
