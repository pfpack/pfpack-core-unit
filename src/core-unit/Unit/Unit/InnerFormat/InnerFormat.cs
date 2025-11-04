using System.Runtime.CompilerServices;

namespace System;

partial struct Unit
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string InnerFormat(ReadOnlySpan<char> format)
    {
        const string canonicalForm = "()";
        const string jsonObjForm = "{}";
        const string emptyForm = "";

        const string canonicalFormExtended = "Unit:()";
        const string jsonObjFormExtended = "Unit:{}";
        const string emptyFormExtended = "Unit";

        const string generalForm = canonicalFormExtended;

        return format switch
        {
            [] or ['G' or 'g'] => generalForm,

            ['U' or 'u'] => canonicalForm,
            ['J' or 'j'] => jsonObjForm,
            ['E' or 'e'] => emptyForm,

            ['U' or 'u', 'X' or 'x'] => canonicalFormExtended,
            ['J' or 'j', 'X' or 'x'] => jsonObjFormExtended,
            ['E' or 'e', 'X' or 'x'] => emptyFormExtended,

            _ => generalForm
        };
    }
}
