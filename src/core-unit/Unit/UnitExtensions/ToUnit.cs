namespace System;

partial class UnitExtensions
{
    // We maintain that Unit can be derived from any input value.
    // Unit.From is being called instead of returning default(Unit) for the sake of clarity.
    //
    // Don't apply AggressiveInlining to this extension since it's already applied to Unit.From
    // and redundant use of this attribute can reduce performance.
    //
    // This extension is for more convenient syntax when converting to Unit from a result value.

    public static Unit ToUnit<TResult>(this TResult result)
        =>
        Unit.From(result);
}
