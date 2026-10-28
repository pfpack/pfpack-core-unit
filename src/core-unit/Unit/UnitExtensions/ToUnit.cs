#pragma warning disable IDE0060 // Remove unused parameter

using System.Runtime.CompilerServices;

namespace System;

partial class UnitExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit ToUnit<TResult>(this TResult result) => default;
}
