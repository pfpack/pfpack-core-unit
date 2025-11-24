using System.Runtime.CompilerServices;

namespace System;

partial class UnitExtensions
{
    // We maintain that Unit can be derived from any input value.
    //
    // This extension is for more convenient syntax when converting to Unit from a result value.

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit ToUnit<TResult>(this TResult result)
        =>
        Unit.From(result);
}
