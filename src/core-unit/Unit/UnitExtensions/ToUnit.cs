#pragma warning disable IDE0060 // Remove unused parameter

using System.Runtime.CompilerServices;

namespace System;

partial class UnitExtensions
{
    // We maintain that Unit can be derived from any input value.
    //
    // This extension is for more convenient syntax when getting Unit from a result value.
    //
    // (For better performance, default(Unit) is returned instead of calling symmetric Unit.From factory.)

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit ToUnit<TResult>(this TResult result) => default;
}
