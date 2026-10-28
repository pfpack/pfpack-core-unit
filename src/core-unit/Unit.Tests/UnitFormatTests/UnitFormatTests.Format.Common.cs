using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    public static IEnumerable<TheoryDataRow<string?, string>> ExpectedFormatCases
        =>
        [
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
            (null, UnitForm.General),
            ("", UnitForm.General),

            ("G", UnitForm.General),
            ("g", UnitForm.General),

            ("U", UnitForm.Canonical),
            ("u", UnitForm.Canonical),

            ("J", UnitForm.JsonObj),
            ("j", UnitForm.JsonObj),

            ("UX", UnitForm.CanonicalExtended),
            ("ux", UnitForm.CanonicalExtended),
            ("Ux", UnitForm.CanonicalExtended),
            ("uX", UnitForm.CanonicalExtended),

            ("JX", UnitForm.JsonObjExtended),
            ("jx", UnitForm.JsonObjExtended),
            ("Jx", UnitForm.JsonObjExtended),
            ("jX", UnitForm.JsonObjExtended),

            ("EX", UnitForm.EmptyExtended),
            ("ex", UnitForm.EmptyExtended),
            ("Ex", UnitForm.EmptyExtended),
            ("eX", UnitForm.EmptyExtended),

            ("AnUnknown", UnitForm.General),
        ];

    private static class UnitForm
    {
        internal const string General = CanonicalExtended;

        internal const string Canonical = "()";
        internal const string JsonObj = "{}";
        internal const string Empty = "";

        internal const string CanonicalExtended = "Unit:()";
        internal const string JsonObjExtended = "Unit:{}";
        internal const string EmptyExtended = "Unit";
    }
}
