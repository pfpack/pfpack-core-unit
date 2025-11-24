using System.Runtime.CompilerServices;

namespace System;

partial struct Unit
{
    public static readonly Unit Value;

    // This factory is for use in method group conversion instead of lambda expressions
    // like "() => default(Unit)", "() => new Unit()", or "() => Unit.Value".

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit Get() => default;
}
