using System.Collections.Generic;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    public static IEnumerable<TheoryDataRow<string?>> ParseCases
        =>
        [(string?)null, .. EnumerateNotNullParseCases()];

    public static IEnumerable<TheoryDataRow<string>> NotNullParseCases
        =>
        [.. EnumerateNotNullParseCases()];

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
