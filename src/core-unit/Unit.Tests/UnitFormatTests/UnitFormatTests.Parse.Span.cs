using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void ParseSpan_Succeeds(string? s)
	{
		var actual = Unit.Parse(s.AsSpan(), null);

		var expected = default(Unit);

		Assert.StrictEqual(expected, actual);
	}

	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void TryParseSpan_Succeeds(string? s)
	{
		var actual = Unit.TryParse(s.AsSpan(), null, out var result);

		var expected = default(Unit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}
}
