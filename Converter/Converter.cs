using System;

namespace Converter
{
    public static class Converter
    {
        public static int ToInt32(this string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Can't be null or empty", nameof(value));

            var sign = 1;
            var position = 0;

            var firstSymbol = value[0];
            if (firstSymbol == '-')
            {
                sign = -1;
                position = 1;
            }
            else if (firstSymbol == '+')
            {
                position = 1;
            }

            if (position == 1 && value.Length == 1) // if string contains only sign
                throw new FormatException($"String {value} doesn't match number format");

            var result = 0;
            for(; position < value.Length; position++)
            {
                var symbol = value[position];
                if (!char.IsDigit(symbol))
                    throw new FormatException($"String {value} doesn't match number format at {position} position");

                checked
                {
                    result = result * 10 + sign * (symbol - 0x30);
                }
            }

            return result;
        }
    }
}
