using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata20171118_TribonaciiNumber
{
    public partial class Tribonacii
    {
        public double[] GetNumbers(double[] inputNumbers, int numberslength)
        {
            if (numberslength == 0)
            {
                return new double[] { 0 };
            }

            var resultNumbers = new List<double>();
            for (var index = 0; index < numberslength; index++)
            {
                if (index < 3)
                {
                    resultNumbers.Add(inputNumbers[index]);
                }
                else
                {
                    resultNumbers.Add(resultNumbers[index - 1] + resultNumbers[index - 2] + resultNumbers[index - 3]);
                }
            }
            return resultNumbers.ToArray();
        }
    }
}