using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ExpectedFormatCases))]
	public static void FormatToString_ExpectCorrespondingResult(string? format, string expected)
	{
		var actual = Unit.Format(format);

		Assert.Equal(expected, actual);
	}
}
