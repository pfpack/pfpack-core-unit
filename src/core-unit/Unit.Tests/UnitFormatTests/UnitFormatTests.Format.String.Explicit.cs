using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToStringExplicit_ExpectCorrespondingResult((string? Format, string Expected) testCase)
	{
		var source = (IFormattable)default(Unit);
		var actual = source.ToString(testCase.Format, null);

		Assert.Equal(testCase.Expected, actual);
	}
}
