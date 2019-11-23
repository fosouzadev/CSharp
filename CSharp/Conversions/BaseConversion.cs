using System;

namespace Conversions
{
    public static class BaseConversion
    {
        public static string DecimalToBinary(long number)
        {
            return Convert.ToString(number, toBase: 2);
        }

        public static string DecimalToHexadecimal(long number)
        {
            return Convert.ToString(number, toBase: 16).ToUpper();
        }

        public static long BinaryToDecimal(string binary)
        {
            return Convert.ToInt64(binary, 2);
        }

        public static long HexadecimalToDecimal(string binary)
        {
            return Convert.ToInt64(binary, 16);
        }
    }
}