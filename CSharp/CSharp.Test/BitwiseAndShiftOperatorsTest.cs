using BitwiseAndShiftOperators;
using Xunit;

namespace CSharp.Test
{
    public class BitwiseAndShiftOperatorsTest
    {
        [Fact]
        public void BitwiseComplementOperator_Default_ReturnResult()
        {
            int number = 11;        // 00000000000000000000000000001011   32 bits
            string numberExpected = "-12";
            string binaryExpected = "11111111111111111111111111110100";

            Result actual = BitwiseComplementOperator.Solution(number);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }

        [Fact]
        public void LeftRightShiftOperator_Left_ReturnResult()
        {
            int number = 11;        // 1011
            string numberExpected = "44";
            string binaryExpected = "101100";

            Result actual = LeftRightShiftOperator.Solution(number, 'L', 2);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }

        [Fact]
        public void LeftRightShiftOperator_Right_ReturnResult()
        {
            int number = 11;        // 1011
            string numberExpected = "2";
            string binaryExpected = "10";

            Result actual = LeftRightShiftOperator.Solution(number, 'R', 2);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }

        [Fact]
        public void AndOrOperator_And_ReturnResult()
        {
            /*
             0011 0010 = 50
             0000 1011 = 11
             ---------
             0000 0010
             */

            int number1 = 11;
            int number2 = 50;
            string numberExpected = "2";
            string binaryExpected = "10";

            Result actual = AndOrOperator.SolutionAnd(number1, number2);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }

        [Fact]
        public void AndOrOperator_Or_ReturnResult()
        {
            /*
             0011 0010 = 50
             0000 1011 = 11
             ---------
             0011 1011
             */

            int number1 = 11;
            int number2 = 50;
            string numberExpected = "59";
            string binaryExpected = "111011";

            Result actual = AndOrOperator.SolutionOr(number1, number2);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }

        [Fact]
        public void ExclusiveOrOperator_ExclusiveOr_ReturnResult()
        {
            /*
             0011 0010 = 50
             0000 1011 = 11
             ---------
             0011 1001
             */

            int number1 = 11;
            int number2 = 50;
            string numberExpected = "57";
            string binaryExpected = "111001";

            Result actual = ExclusiveOrOperator.Solution(number1, number2);

            Assert.True(actual.Number == numberExpected && actual.Binary == binaryExpected);
        }
    }
}