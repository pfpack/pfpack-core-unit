using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void ParseStringExplicit_Succeeds(string? s)
		=>
		Inner_ParseStringExplicit_Succeeds<Unit>(s);

	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void TryParseStringExplicit_Succeeds(string? s)
		=>
		Inner_TryParseStringExplicit_Succeeds<Unit>(s);

	private static void Inner_ParseStringExplicit_Succeeds<TUnit>(string? s)
		where TUnit : struct, IParsable<TUnit>
	{
		var actual = TUnit.Parse(s!, null);

		var expected = default(TUnit);

		Assert.StrictEqual(expected, actual);
	}

	private static void Inner_TryParseStringExplicit_Succeeds<TUnit>(string? s)
		where TUnit : struct, IParsable<TUnit>
	{
		var actual = TUnit.TryParse(s, null, out var result);

		var expected = default(TUnit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}
}
