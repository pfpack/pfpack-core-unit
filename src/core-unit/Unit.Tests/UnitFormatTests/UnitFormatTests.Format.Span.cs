using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsEqual_ExpectSuccessResult((string? Format, string Expected) testCase)
	{
		var (format, expected) = (testCase.Format, testCase.Expected.ToCharArray());

		var destination = new char[expected.Length];

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination);
	}

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsGreater_ExpectSuccessResult((string? Format, string Expected) testCase)
	{
		var (format, expected) = (testCase.Format, testCase.Expected.ToCharArray());

		const int extraLength = 1;
		const char filler = 'X';

		var destination = new char[expected.Length + extraLength];
		destination.AsSpan(start: expected.Length).Fill(filler);

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination[..expected.Length]);

		var expectedExtra = new char[extraLength];
		expectedExtra.AsSpan().Fill(filler);
		Assert.Equal(expectedExtra, destination[expected.Length..]);
	}

	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToSpan_DestLengthIsLess_ExpectFailureResult((string? Format, string Expected) testCase)
	{
		var (format, expectedLength) = (testCase.Format, testCase.Expected.Length);

		if (expectedLength == 0)
		{
			// Skip inapplicable case
			Assert.False(false);
			return;
		}

		const char filler = 'X';

		var destination = new char[expectedLength - 1];
		destination.AsSpan().Fill(filler);

		var source = default(Unit);
		var actualResult = source.TryFormat(destination.AsSpan(), out var actualCharsWritten, format, null);

		Assert.False(actualResult);
		Assert.Equal(0, actualCharsWritten);

		var expectedDestination = new char[destination.Length];
		expectedDestination.AsSpan().Fill(filler);
		Assert.Equal(expectedDestination, destination);
	}
}
