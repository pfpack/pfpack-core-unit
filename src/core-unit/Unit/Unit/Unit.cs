using System.Numerics;
using System.Text.Json.Serialization;

namespace System;

[JsonConverter(typeof(UnitJsonConverter))]
public readonly partial struct Unit :
    IEquatable<Unit>,
    IComparable<Unit>,
    IEqualityOperators<Unit, Unit, bool>,
    IComparisonOperators<Unit, Unit, bool>,
    IFormattable,
    ISpanFormattable,
    IUtf8SpanFormattable,
    IParsable<Unit>,
    ISpanParsable<Unit>,
    IUtf8SpanParsable<Unit>
{
}
