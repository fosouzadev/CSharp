using Conversions;
using Xunit;

namespace CSharp.Test.ConversionsTest
{
    public class BaseConversionTest
    {
        [Theory]
        [InlineData(11, "1011")]
        [InlineData(78, "1001110")]
        [InlineData(96, "1100000")]
        public void DecimalToBinary_Default_ReturnBinary(long number, string expected)
        {
            string actual = BaseConversion.DecimalToBinary(number);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(11, "B")]
        [InlineData(78, "4E")]
        [InlineData(96, "60")]
        public void DecimalToHexadecimal_Default_ReturnHexadecimal(long number, string expected)
        {
            string actual = BaseConversion.DecimalToHexadecimal(number);

            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData("1011", 11)]
        [InlineData("1001110", 78)]
        [InlineData("1100000", 96)]
        public void BinaryToDecimal_Default_ReturnDecimal(string value, long expected)
        {
            long actual = BaseConversion.BinaryToDecimal(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("B", 11)]
        [InlineData("4E", 78)]
        [InlineData("60", 96)]
        public void HexadecimalToDecimal_Default_ReturnDecimal(string value, long expected)
        {
            long actual = BaseConversion.HexadecimalToDecimal(value);

            Assert.Equal(expected, actual);
        }
    }
}