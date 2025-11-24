#pragma warning disable IDE0060 // Remove unused parameter

using System.Runtime.CompilerServices;

namespace System;

partial struct Unit
{
    // We maintain that Unit can be derived from any input value.
    //
    // This factory is for use in method group conversion instead of lambda expressions
    // like "_ => default(Unit)", "_ => new Unit()", or "_ => Unit.Value".

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit From<TResult>(TResult result) => default;
}
