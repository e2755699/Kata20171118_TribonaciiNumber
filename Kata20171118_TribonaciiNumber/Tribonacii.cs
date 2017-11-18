using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata20171118_TribonaciiNumber
{
    public partial class Tribonacii
    {
        public double[] GetNumbers(double[] initialNumbers, int tribaNumberLength)
        {
            if (tribaNumberLength == 0)
            {
                return new double[] { 0 };
            }

            var answer = new double[tribaNumberLength];
            Array.Copy(initialNumbers, answer, Math.Min(3, tribaNumberLength));

            for (var index = 3; index < tribaNumberLength; index++)
            {
                answer[index] = answer[index - 1] + answer[index - 2] + answer[index - 3];
            }
            return answer.ToArray();
        }
    }
}