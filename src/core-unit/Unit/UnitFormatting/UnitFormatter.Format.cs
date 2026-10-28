using System.Runtime.CompilerServices;

namespace System;

partial class UnitFormatter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string Format(ReadOnlySpan<char> format)
        =>
        format switch
        {
            [] or ['G' or 'g'] => UnitForm.General,

            ['U' or 'u'] => UnitForm.Canonical,
            ['J' or 'j'] => UnitForm.JsonObj,
            ['E' or 'e'] => UnitForm.Empty,

            ['U' or 'u', 'X' or 'x'] => UnitForm.CanonicalExtended,
            ['J' or 'j', 'X' or 'x'] => UnitForm.JsonObjExtended,
            ['E' or 'e', 'X' or 'x'] => UnitForm.EmptyExtended,

            _ => UnitForm.General
        };
}
