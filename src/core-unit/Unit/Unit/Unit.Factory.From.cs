#pragma warning disable IDE0060 // Remove unused parameter

using System.Runtime.CompilerServices;

namespace System;

partial struct Unit
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit From<TResult>(TResult result) => default;
}
