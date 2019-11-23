using System;

namespace BitwiseAndShiftOperators
{
    /// <summary>
    /// Converte o número inteiro em binário, adicionando bits a esquerda ou a direita, empurrando os demais
    /// </summary>
    public static class LeftRightShiftOperator
    {
        public static Result Solution(int number, char direction, int salt)
        {
            switch (direction)
            {
                case 'L':
                    var left = number << salt;
                    return new Result { Number = left.ToString(), Binary = Convert.ToString(left, toBase: 2) };
                case 'R':
                    var right = number >> salt;
                    return new Result { Number = right.ToString(), Binary = Convert.ToString(right, toBase: 2) };
                default:
                    return null;
            }
        }
    }
}