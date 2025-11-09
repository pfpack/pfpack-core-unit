namespace System;

partial class UnitExtensions
{
    // We maintain that Unit can be derived from any input value.

    public static Unit ToUnit<TResult>(this TResult result)
        =>
        Unit.From(result);
}
