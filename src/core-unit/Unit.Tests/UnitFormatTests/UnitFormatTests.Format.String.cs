using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToString_ExpectCorrespondingResult((string? Format, string Expected) testCase)
	{
		var actual = Unit.Format(testCase.Format);

		Assert.Equal(testCase.Expected, actual);
	}
}
