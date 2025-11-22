using System.Text;

namespace System;

internal static class UnitFormUtf8
{
    // General (default) form
    private static readonly byte[] general = Utf8.GetBytes(UnitForm.General);

    // Basic forms
    private static readonly byte[] canonical = Utf8.GetBytes(UnitForm.Canonical);
    private static readonly byte[] jsonObj = Utf8.GetBytes(UnitForm.JsonObj);
    private static readonly byte[] empty = Utf8.GetBytes(UnitForm.Empty);

    // Extended forms
    private static readonly byte[] canonicalExtended = Utf8.GetBytes(UnitForm.CanonicalExtended);
    private static readonly byte[] jsonObjExtended = Utf8.GetBytes(UnitForm.JsonObjExtended);
    private static readonly byte[] emptyExtended = Utf8.GetBytes(UnitForm.EmptyExtended);

    private static Encoding Utf8 => Encoding.UTF8;

    // General (default) form
    internal static ReadOnlySpan<byte> General => new(general);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => new(canonical);
    internal static ReadOnlySpan<byte> JsonObj => new(jsonObj);
    internal static ReadOnlySpan<byte> Empty => new(empty);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => new(canonicalExtended);
    internal static ReadOnlySpan<byte> JsonObjExtended => new(jsonObjExtended);
    internal static ReadOnlySpan<byte> EmptyExtended => new(emptyExtended);
}
