namespace System;

partial struct Unit
{
	static Unit IParsable<Unit>.Parse(string? s, IFormatProvider? provider)
		=>
		default;

	static Unit ISpanParsable<Unit>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
		=>
		default;

	static Unit IUtf8SpanParsable<Unit>.Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
		=>
		default;

	static bool IParsable<Unit>.TryParse(string? s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}

	static bool ISpanParsable<Unit>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}

	static bool IUtf8SpanParsable<Unit>.TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}
}
