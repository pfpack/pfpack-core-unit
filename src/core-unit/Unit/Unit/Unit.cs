using System.Text.Json.Serialization;

namespace System;

[JsonConverter(typeof(UnitJsonConverter))]
public readonly partial struct Unit : IEquatable<Unit>, IComparable<Unit>, IComparable
{
}
