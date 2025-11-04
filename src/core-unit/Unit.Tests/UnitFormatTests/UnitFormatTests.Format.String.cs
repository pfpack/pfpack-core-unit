using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToString_ExpectCorrespondingResult((string? Format, string Expected) testCase)
	{
		var source = default(Unit);
		var actual = source.ToString(testCase.Format, null);

		Assert.Equal(testCase.Expected, actual);
	}
}
