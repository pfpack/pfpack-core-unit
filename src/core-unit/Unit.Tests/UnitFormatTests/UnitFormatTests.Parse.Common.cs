using System.Collections.Generic;
using System.Linq;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
	public static TheoryData<string?> ParseCases
#pragma warning disable IDE0028 // Simplify collection initialization
#pragma warning disable IDE0305 // Simplify collection initialization
		=>
		new(EnumerateParseCases().ToArray());

	public static TheoryData<string> ParseCasesWithoutNull
		=>
		new(EnumerateParseCasesWithoutNull().ToArray());
#pragma warning restore IDE0305 // Simplify collection initialization
#pragma warning restore IDE0028 // Simplify collection initialization

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
