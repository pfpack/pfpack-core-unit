using System;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	[Fact]
	public static void ToString_ExpectGeneralResult()
	{
		var source = default(Unit);
		var actual = source.ToString();

		const string expected = "Unit:()";
		Assert.Equal(expected, actual);
	}
}
