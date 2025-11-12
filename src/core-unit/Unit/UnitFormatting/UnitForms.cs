namespace System;

internal static class UnitForms
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
