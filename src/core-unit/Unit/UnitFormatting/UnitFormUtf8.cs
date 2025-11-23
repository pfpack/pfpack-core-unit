using System.Text;

namespace System;

internal static class UnitFormUtf8
{
    // General (default) form
    internal static ReadOnlySpan<byte> General => new(InnerBytes.General);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => new(InnerBytes.Canonical);
    internal static ReadOnlySpan<byte> JsonObj => new(InnerBytes.JsonObj);
    internal static ReadOnlySpan<byte> Empty => new(InnerBytes.Empty);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => new(InnerBytes.CanonicalExtended);
    internal static ReadOnlySpan<byte> JsonObjExtended => new(InnerBytes.JsonObjExtended);
    internal static ReadOnlySpan<byte> EmptyExtended => new(InnerBytes.EmptyExtended);

    private static class InnerBytes
    {
        internal static readonly byte[] General = Utf8.GetBytes(UnitForm.General);

        internal static readonly byte[] Canonical = Utf8.GetBytes(UnitForm.Canonical);
        internal static readonly byte[] JsonObj = Utf8.GetBytes(UnitForm.JsonObj);
        internal static readonly byte[] Empty = Utf8.GetBytes(UnitForm.Empty);

        internal static readonly byte[] CanonicalExtended = Utf8.GetBytes(UnitForm.CanonicalExtended);
        internal static readonly byte[] JsonObjExtended = Utf8.GetBytes(UnitForm.JsonObjExtended);
        internal static readonly byte[] EmptyExtended = Utf8.GetBytes(UnitForm.EmptyExtended);

        private static Encoding Utf8 => Encoding.UTF8;
    }
}
