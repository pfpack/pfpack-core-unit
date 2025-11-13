using System.Runtime.CompilerServices;

namespace System;

internal static class UnitFormatter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string Format(ReadOnlySpan<char> format)
        =>
        format switch
        {
            // General (default) form
            [] or ['G' or 'g'] => UnitForm.General,

            // Basic forms
            ['U' or 'u'] => UnitForm.Canonical,
            ['J' or 'j'] => UnitForm.JsonObj,
            ['E' or 'e'] => UnitForm.Empty,

            // Extended forms
            ['U' or 'u', 'X' or 'x'] => UnitForm.CanonicalExtended,
            ['J' or 'j', 'X' or 'x'] => UnitForm.JsonObjExtended,
            ['E' or 'e', 'X' or 'x'] => UnitForm.EmptyExtended,

            // Fallback to default
            _ => UnitForm.General
        };
}
