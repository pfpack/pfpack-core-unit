namespace System;

partial class UnitExtensions
{
    // We maintain that Unit can be derived from any input value.
    // Unit.From is being called instead of returning default(Unit) for the sake of clarity.
    //
    // This extension is for more convenient syntax when converting to Unit from a result value.

    public static Unit ToUnit<TResult>(this TResult result)
        =>
        Unit.From(result);
}
