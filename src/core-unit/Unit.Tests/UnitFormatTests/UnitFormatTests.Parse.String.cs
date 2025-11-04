using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void ParseString_Succeeds(string? s)
	{
		var actual = Unit.Parse(s, null);

		var expected = default(Unit);

		Assert.StrictEqual(expected, actual);
	}

	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void TryParseString_Succeeds(string? s)
	{
		var actual = Unit.TryParse(s, null, out var result);

		var expected = default(Unit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}
}
