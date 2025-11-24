using System.Runtime.CompilerServices;

namespace System;

partial struct Unit
{
    // This singleton value is for use when it's needed to emphasize that Unit is being used.
    // In other cases, prefer "default(Unit)" or "new Unit()" for better performance.

    public static readonly Unit Value;

    // This factory is for use in method group conversion instead of lambda expressions
    // like "() => default(Unit)", "() => new Unit()", or "() => Unit.Value".

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit Get() => default;
}
