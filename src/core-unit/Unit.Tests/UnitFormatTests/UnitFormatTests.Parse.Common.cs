using System.Collections.Generic;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	public static TheoryData<string?> ParseCases
		=>
		new([.. EnumerateParseCases()]);

	public static TheoryData<string> ParseCasesWithoutNull
		=>
		new([.. EnumerateParseCasesWithoutNull()]);

	private static IEnumerable<string?> EnumerateParseCases()
		=>
		[null, .. EnumerateParseCasesWithoutNull()];

	private static IEnumerable<string> EnumerateParseCasesWithoutNull()
		=>
		[
			"()",
			"{}",
			"",
			"Unit:()",
			"Unit:{}",
			"Unit",
			"AnUnknown"
		];
}
