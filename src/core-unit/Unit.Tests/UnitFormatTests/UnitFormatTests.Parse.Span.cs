using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void ParseSpan_Succeeds(string? s)
		=>
		Inner_ParseSpan_Succeeds<Unit>(s);

	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void TryParseSpan_Succeeds(string? s)
		=>
		Inner_TryParseSpan_Succeeds<Unit>(s);

	private static void Inner_ParseSpan_Succeeds<TUnit>(string? s)
		where TUnit : struct, ISpanParsable<TUnit>
	{
		ReadOnlySpan<char> span = s;
		var actual = TUnit.Parse(span, null);

		var expected = default(TUnit);

		Assert.StrictEqual(expected, actual);
	}

	private static void Inner_TryParseSpan_Succeeds<TUnit>(string? s)
		where TUnit : struct, ISpanParsable<TUnit>
	{
		ReadOnlySpan<char> span = s;
		var actual = TUnit.TryParse(span, null, out var result);

		var expected = default(TUnit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}
}
