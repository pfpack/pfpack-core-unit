using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    public static IEnumerable<TheoryDataRow<string?, string>> ExpectedFormatCases
        =>
        [
            // Empty format
            ("E", UnitForm.Empty),
            ("e", UnitForm.Empty),
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
            (null, UnitForm.General),
            ("", UnitForm.General),

            // General format
            ("G", UnitForm.General),
            ("g", UnitForm.General),

            // Canonical format
            ("U", UnitForm.Canonical),
            ("u", UnitForm.Canonical),

            // JSON Object format
            ("J", UnitForm.JsonObj),
            ("j", UnitForm.JsonObj),

            // Empty format - miss here on purpose

            // Canonical entended
            ("UX", UnitForm.CanonicalExtended),
            ("ux", UnitForm.CanonicalExtended),
            ("Ux", UnitForm.CanonicalExtended),
            ("uX", UnitForm.CanonicalExtended),

            // JSON entended
            ("JX", UnitForm.JsonObjExtended),
            ("jx", UnitForm.JsonObjExtended),
            ("Jx", UnitForm.JsonObjExtended),
            ("jX", UnitForm.JsonObjExtended),

            // Empty entended
            ("EX", UnitForm.EmptyExtended),
            ("ex", UnitForm.EmptyExtended),
            ("Ex", UnitForm.EmptyExtended),
            ("eX", UnitForm.EmptyExtended),

            // Unknown format
            ("AnUnknown", UnitForm.General),
        ];

    private static class UnitForm
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
