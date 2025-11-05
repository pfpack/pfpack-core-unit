using System.Text;

namespace System;

partial struct Unit
{
	// IFormattable

	public string ToString(string? format, IFormatProvider? formatProvider)
		=>
		UnitFormatter.ToString(format);

	// ISpanFormattable

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
	{
		var formatted = UnitFormatter.ToString(format);

		if (formatted.TryCopyTo(destination))
		{
			charsWritten = formatted.Length;
			return true;
		}

		charsWritten = default;
		return false;
	}

	// IUtf8SpanFormattable

	public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
	{
		ReadOnlySpan<byte> utf8Formatted = new(Encoding.UTF8.GetBytes(UnitFormatter.ToString(format)));

		if (utf8Formatted.TryCopyTo(utf8Destination))
		{
			bytesWritten = utf8Formatted.Length;
			return true;
		}

		bytesWritten = default;
		return false;
	}
}
