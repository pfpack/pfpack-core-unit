using System;
using System.Text;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void ParseSpanUtf8_Succeeds(string? s)
	{
		var bytes = s is not null ? Encoding.UTF8.GetBytes(s) : null;
		var actual = Unit.Parse(bytes.AsSpan(), null);

		var expected = default(Unit);

		Assert.StrictEqual(expected, actual);
	}

	[Theory]
	[MemberData(nameof(ParseCases))]
	public static void TryParseSpanUtf8_Succeeds(string? s)
	{
		var bytes = s is not null ? Encoding.UTF8.GetBytes(s) : null;
		var actual = Unit.TryParse(bytes.AsSpan(), null, out var result);

		var expected = default(Unit);

		Assert.True(actual);
		Assert.StrictEqual(expected, result);
	}
}
