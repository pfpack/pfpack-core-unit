namespace System;

partial struct Unit
{
	// IParsable<Unit>

	public static Unit Parse(string? s, IFormatProvider? provider)
		=>
		default;

	public static bool TryParse(string? s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}

	// ISpanParsable<Unit>

	public static Unit Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
		=>
		default;

	public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}

	// IUtf8SpanParsable<Unit>

	public static Unit Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
		=>
		default;

	public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}
}
