using System;

namespace BitwiseAndShiftOperators
{
    public static class ExclusiveOrOperator
    {
        /// <summary>
        /// Converte os números inteiros em binário, e aplica uma comparação bit a bit com o operador 'OU' exclusivo
        /// 0 e 0 = 0
        /// 0 e 1 = 1
        /// 1 e 1 = 0
        /// 1 e 0 = 1
        /// </summary>
        public static Result Solution(int number1, int number2)
        {
            var res = number1 ^ number2;

            return new Result { Number = res.ToString(), Binary = Convert.ToString(res, toBase: 2) };
        }
    }
}