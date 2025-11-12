using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    public static IEnumerable<TheoryDataRow<string?, string>> ExpectedFormatCases
        =>
        [
            // Empty format
            ("E", UnitForms.Empty),
            ("e", UnitForms.Empty),
            ..
            EnumerateExpectedFormatCases_WithoutEmptyResult(),
        ];

    public static IEnumerable<TheoryDataRow<string?, string>> ExpectedFormatCases_WithoutEmptyResult
        =>
        [.. EnumerateExpectedFormatCases_WithoutEmptyResult()];


    private static IEnumerable<(string?, string)> EnumerateExpectedFormatCases_WithoutEmptyResult()
        =>
        [
            // Default format
            (null, UnitForms.General),
            ("", UnitForms.General),

            // General format
            ("G", UnitForms.General),
            ("g", UnitForms.General),

            // Canonical format
            ("U", UnitForms.Canonical),
            ("u", UnitForms.Canonical),

            // JSON Object format
            ("J", UnitForms.JsonObj),
            ("j", UnitForms.JsonObj),

            // Empty format - miss here on purpose

            // Canonical entended
            ("UX", UnitForms.CanonicalExtended),
            ("ux", UnitForms.CanonicalExtended),
            ("Ux", UnitForms.CanonicalExtended),
            ("uX", UnitForms.CanonicalExtended),

            // JSON entended
            ("JX", UnitForms.JsonObjExtended),
            ("jx", UnitForms.JsonObjExtended),
            ("Jx", UnitForms.JsonObjExtended),
            ("jX", UnitForms.JsonObjExtended),

            // Empty entended
            ("EX", UnitForms.EmptyExtended),
            ("ex", UnitForms.EmptyExtended),
            ("Ex", UnitForms.EmptyExtended),
            ("eX", UnitForms.EmptyExtended),

            // Unknown format
            ("AnUnknown", UnitForms.General),
        ];

    private static class UnitForms
    {
        // General (default) form
        internal const string General = CanonicalExtended;

        // Basic forms
        internal const string Canonical = "()";
        internal const string JsonObj = "{}";
        internal const string Empty = "";

        // Extended forms
        internal const string CanonicalExtended = "Unit:()";
        internal const string JsonObjExtended = "Unit:{}";
        internal const string EmptyExtended = "Unit";
    }
}
