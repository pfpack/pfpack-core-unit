using System.Collections.Generic;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	public static TheoryData<string?> ParseCases
		=>
		new([.. EnumerateParseCases()]);

	public static TheoryData<string> NotNullParseCases
		=>
		new([.. EnumerateNotNullParseCases()]);

	private static IEnumerable<string?> EnumerateParseCases()
		=>
		[null, .. EnumerateNotNullParseCases()];

	private static IEnumerable<string> EnumerateNotNullParseCases()
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
