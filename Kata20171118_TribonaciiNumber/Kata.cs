using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20171118_TribonaciiNumber
{
    [TestClass]
    public class Kata
    {
        private Tribonacii tribonaciiNumbers;

        public Kata()
        {
            tribonaciiNumbers = new Tribonacii();
        }

        [TestMethod]
        public void Input_0_0_1_andLegnthIs_3()
        {
            //arrange
            var inputNumbers = new double[]{0, 0, 1};
            var Numberslength = 3;
            var expect = new double[]{0, 0 ,1};
            //act
            var actual = GetNumbers(inputNumbers, Numberslength);
            //assert
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_0_0_1_andLengthIs_4()
        {
            //arrange
            var inputNumber = new double[]{0, 0, 1};
            var NumberLength = 4;
            var expect = new double[]{0, 0, 1, 1};
            //act
            var actual = GetNumbers(inputNumber, NumberLength);
            //assert
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void kataTestCase()
        {
            //arrange
            AssertShouldBe(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, new double[] { 1, 1, 1}, 10);
        }

        private void AssertShouldBe(double[] expect, double[] inputNumber, int numberLength)
        {
            //act
            var actual = GetNumbers(inputNumber, numberLength);
            //assert
            CollectionAssert.AreEqual(expect, actual);
        }

        private double[] GetNumbers(double[] inputNumbers, int numberslength)
        {
            return tribonaciiNumbers.GetNumbers(inputNumbers, numberslength);
        }
    }
}
