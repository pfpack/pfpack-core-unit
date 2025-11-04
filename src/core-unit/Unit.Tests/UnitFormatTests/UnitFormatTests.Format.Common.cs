using System.Collections.Generic;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{

	public static TheoryData<(string? Format, string Expected)> ExpectedFormatCases
		=>
		new([.. EnumerateExpectedFormatCases()]);

	private static IEnumerable<(string? Format, string Expected)> EnumerateExpectedFormatCases()
	{
		const string canonicalForm = "()";
		const string jsonObjForm = "{}";
		const string emptyForm = "";

		const string canonicalFormExtended = "Unit:()";
		const string jsonObjFormExtended = "Unit:{}";
		const string emptyFormExtended = "Unit";

		// Default format
		yield return (null, canonicalFormExtended);
		yield return ("", canonicalFormExtended);

		// General format
		yield return ("G", canonicalFormExtended);
		yield return ("g", canonicalFormExtended);

		// Canonical format
		yield return ("U", canonicalForm);
		yield return ("u", canonicalForm);

		// JSON Object format
		yield return ("J", jsonObjForm);
		yield return ("j", jsonObjForm);

		// Empty format
		yield return ("E", emptyForm);
		yield return ("e", emptyForm);

		// Canonical entended
		yield return ("UX", canonicalFormExtended);
		yield return ("ux", canonicalFormExtended);
		yield return ("Ux", canonicalFormExtended);
		yield return ("uX", canonicalFormExtended);

		// JSON entended
		yield return ("JX", jsonObjFormExtended);
		yield return ("jx", jsonObjFormExtended);
		yield return ("Jx", jsonObjFormExtended);
		yield return ("jX", jsonObjFormExtended);

		// Empty entended
		yield return ("EX", emptyFormExtended);
		yield return ("ex", emptyFormExtended);
		yield return ("Ex", emptyFormExtended);
		yield return ("eX", emptyFormExtended);

		// Unknown format
		yield return ("AnUnknown", canonicalFormExtended);
	}
}
