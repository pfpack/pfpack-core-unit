#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member

namespace System;

partial struct Unit
{
    [Obsolete("This method is not intended for use. Call Format instead.")]
    public override string ToString()
        =>
        Format();
}
