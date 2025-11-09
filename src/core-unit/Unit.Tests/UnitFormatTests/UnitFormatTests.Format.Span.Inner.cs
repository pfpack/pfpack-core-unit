using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	private static void Inner_FormatToSpan_DestLengthIsEqual_ExpectSuccessResult(
		Func<Span<char>, ReadOnlySpan<char>, (bool Result, int CharsWritten)> testFunc,
		(string? Format, string Expected) testCase)
	{
		var format = testCase.Format;
		var expected = testCase.Expected.AsSpan();

		var destination = new char[expected.Length].AsSpan();

		var (actualResult, actualCharsWritten) = testFunc.Invoke(destination, format);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination);
	}

	private static void Inner_FormatToSpan_DestLengthIsGreater_ExpectSuccessResult(
		Func<Span<char>, ReadOnlySpan<char>, (bool Result, int CharsWritten)> testFunc,
		(string? Format, string Expected) testCase)
	{
		var format = testCase.Format;
		var expected = testCase.Expected.AsSpan();

		const int extraLength = 1;
		const char filler = 'X';

		var destination = new char[expected.Length + extraLength].AsSpan();
		destination[expected.Length..].Fill(filler);

		var (actualResult, actualCharsWritten) = testFunc.Invoke(destination, format);

		Assert.True(actualResult);
		Assert.Equal(expected.Length, actualCharsWritten);
		Assert.Equal(expected, destination[..expected.Length]);

		var expectedExtra = new char[extraLength].AsSpan();
		expectedExtra.Fill(filler);
		Assert.Equal(expectedExtra, destination[expected.Length..]);
	}

	private static void Inner_FormatToSpan_DestLengthIsLess_ExpectFailureResult(
		Func<Span<char>, ReadOnlySpan<char>, (bool Result, int CharsWritten)> testFunc,
		(string? Format, string Expected) testCase)
	{
		var (format, expectedLength) = (testCase.Format, testCase.Expected.Length);

		if (expectedLength == 0)
		{
			// Skip inapplicable case
			Assert.False(false);
			return;
		}

		const char filler = 'X';

		var destination = new char[expectedLength - 1].AsSpan();
		destination.Fill(filler);

		var (actualResult, actualCharsWritten) = testFunc.Invoke(destination, format);

		Assert.False(actualResult);
		Assert.Equal(0, actualCharsWritten);

		var expectedDestination = new char[destination.Length].AsSpan();
		expectedDestination.Fill(filler);
		Assert.Equal(expectedDestination, destination);
	}
}
