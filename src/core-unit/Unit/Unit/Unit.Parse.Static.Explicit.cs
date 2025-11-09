namespace System;

partial struct Unit
{
	// Notes on the string versions of parsing, Parse(string, ...) / TryParse(string?, ...):
	//
	// - For the explicit implementation we follow the contract which defines
	// fail for the null input, since the TryParse method has [NotNullWhen(true)]
	// attribute on the input, and breaking the contract when handling null
	// may lead to a violation of the user expectations.
	//
	// - So, for the Parse method we also follow the contract to keep consistency
	// between the Parse and TryParse methods when handling the null input.
	//
	// - To get Unit from a null input, call From method or ToUnit extension,
	// or use deserialization from null JSON token when applicable.

	static Unit IParsable<Unit>.Parse(string s, IFormatProvider? provider)
	{
		_ = s ?? throw new ArgumentNullException(nameof(s));
		return default;
	}

	static bool IParsable<Unit>.TryParse(string? s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return s is not null;
	}

	static Unit ISpanParsable<Unit>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
		=>
		default;

	static bool ISpanParsable<Unit>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}

	static Unit IUtf8SpanParsable<Unit>.Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
		=>
		default;

	static bool IUtf8SpanParsable<Unit>.TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Unit result)
	{
		result = default;
		return true;
	}
}
