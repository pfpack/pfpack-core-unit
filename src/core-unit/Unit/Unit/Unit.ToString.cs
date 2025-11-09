using System.Diagnostics.CodeAnalysis;

namespace System;

partial struct Unit
{
    public override string ToString()
        =>
        UnitForms.General;

    // Redirect to the Format method.

    [Obsolete(NotIntendedMessage_ToStringFormattable, error: true)]
    [DoesNotReturn]
    public string ToString(string? format)
        =>
        throw new NotImplementedException(NotIntendedMessage_ToStringFormattable);

    private const string NotIntendedMessage_ToStringFormattable
        =
        $"This method is not intended for use. Call {nameof(Format)} instead.";
}
