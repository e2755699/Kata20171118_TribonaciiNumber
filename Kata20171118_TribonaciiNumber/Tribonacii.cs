using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata20171118_TribonaciiNumber
{
    public partial class Tribonacii
    {
        public double[] GetNumbers(double[] initialNumbers, int TribaNumberLength)
        {
            if (TribaNumberLength == 0)
            {
                return new double[] { 0 };
            }

            var answer = new double[TribaNumberLength];
            for (var index = 0; index < TribaNumberLength; index++)
            {
                if (index < 3)
                {
                    answer[index] = initialNumbers[index];
                }
                else
                {
                    answer[index] = answer[index - 1] + answer[index - 2] + answer[index - 3];
                }
            }
            return answer.ToArray();
        }
    }
}