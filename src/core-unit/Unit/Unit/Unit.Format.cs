#pragma warning disable CA1822 // Mark members as static

using System.Text;

namespace System;

partial struct Unit
{
    public string Format(ReadOnlySpan<char> format)
        =>
		UnitFormatter.Format(format);

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format)
	{
		var formatted = UnitFormatter.Format(format);

		// Call TryCopyTo instead of CopyTo not to duplicate the length check here
		var result = formatted.TryCopyTo(destination);
		charsWritten = result ? formatted.Length : default;
		return result;
	}

	public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format)
	{
		ReadOnlySpan<byte> utf8Formatted = new(Encoding.UTF8.GetBytes(UnitFormatter.Format(format)));

		// Call TryCopyTo instead of CopyTo not to duplicate the length check here
		var result = utf8Formatted.TryCopyTo(utf8Destination);
		bytesWritten = result ? utf8Formatted.Length : default;
		return result;
	}
}
