namespace System;

partial struct Unit
{
    public override string ToString()
        =>
        UnitForm.General;

    // Redirect from the legacy pattern to the new method.

    [Obsolete($"This method is not intended for use. Call {nameof(Format)} instead.", error: true)]
    public string ToString(string? format)
        =>
        Format(format.AsSpan());
}
