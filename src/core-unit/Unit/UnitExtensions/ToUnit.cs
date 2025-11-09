using System.Runtime.CompilerServices;

namespace System;

partial class UnitExtensions
{
	// We maintain that Unit can be derived from any input value.

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit ToUnit<TResult>(this TResult result)
        =>
        Unit.From(result);
}
