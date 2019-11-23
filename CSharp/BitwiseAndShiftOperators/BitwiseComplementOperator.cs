using System;

namespace BitwiseAndShiftOperators
{
    /// <summary>
    /// Converte os numeros inteiros em binário e inverte os bits
    /// </summary>
    public static class BitwiseComplementOperator
    {
        public static Result Solution(int number)
        {
            var res = ~number;

            return new Result {
                Number = res.ToString(),
                Binary = Convert.ToString(res, toBase: 2)
            };
        }
    }
}