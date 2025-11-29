using System.Runtime.CompilerServices;
using System.Text;

namespace System;

partial class UnitFormUtf8
{
    // We use the most proven method to obtain UTF-8 bytes.

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte[] InnerGetBytes(string s)
        =>
        Encoding.UTF8.GetBytes(s);
}
