namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	public static TheoryData<string?> ParseCases
		=>
		new([
			null,

			"()",
			"{}",
			"",

			"Unit:()",
			"Unit:{}",
			"Unit",

			"AnUnknown"
		]);
}
