using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(NotNullParseCases))]
	public static void ParseStringExplicit_Succeeds(string s)
		=>
		Inner_ParseStringExplicit_Succeeds<Unit>(s);

	[Theory]
	[MemberData(nameof(NotNullParseCases))]
	public static void TryParseStringExplicit_Succeeds(string s)
		=>
		Inner_TryParseStringExplicit_Succeeds<Unit>(s);

	[Fact]
	public static void ParseStringExplicit_NullInput_Fails()
		=>
		Inner_ParseStringExplicit_NullInput_Fails<Unit>();

	[Fact]
	public static void TryParseStringExplicit_NullInput_Fails()
		=>
		Inner_TryParseStringExplicit_NullInput_Fails<Unit>();

	private static void Inner_ParseStringExplicit_Succeeds<TUnit>(string s)
		where TUnit : struct, IParsable<TUnit>
	{
		var actual = TUnit.Parse(s, null);

		var expected = default(TUnit);

		Assert.StrictEqual(expected, actual);
	}

	private static void Inner_TryParseStringExplicit_Succeeds<TUnit>(string s)
		where TUnit : struct, IParsable<TUnit>
	{
		var actual = TUnit.TryParse(s, null, out var result);

		var expected = default(TUnit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}

	private static void Inner_ParseStringExplicit_NullInput_Fails<TUnit>()
		where TUnit : struct, IParsable<TUnit>
	{
		_ = Assert.Throws<ArgumentNullException>("s", () => _ = TUnit.Parse(null!, null));
	}

	private static void Inner_TryParseStringExplicit_NullInput_Fails<TUnit>()
		where TUnit : struct, IParsable<TUnit>
	{
		var actual = TUnit.TryParse(null, null, out var result);

		var expected = default(TUnit);

		Assert.False(actual);
		Assert.StrictEqual(expected, result);
	}
}
