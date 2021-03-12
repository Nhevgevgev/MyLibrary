using NUnit.Framework;

namespace Library.UnitTests
{
    public class CyclesUnitTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 4)]
        [TestCase(-4, 3, -64)]
        [TestCase(8, 3, 512)]
        [TestCase(0, 1, 0)]

        public void RaiseAToPowerBTests(int a, int b, int expected)
        {
            double actual = Cycles.RaiseAToPowerB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(656, new int[] { 656 })]

        public void GetNumbersDivisibleByATests(int a, int[] expected)
        {
            int[] actual = Cycles.GetNumbersDivisibleByA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(1, 0)]
        [TestCase(100, 9)]
        [TestCase(33, 5)]
        [TestCase(77, 8)]

        public void GetNumberOfPositiveIntegersWhoseSquareIsLessThanATests(int a, int expected)
        {
            int actual = Cycles.GetNumberOfPositiveIntegersWhoseSquareIsLessThanA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        [TestCase(2, 1)]
        [TestCase(5, 1)]
        [TestCase(23, 1)]
        [TestCase(150, 75)]

        public void GetGreatestDivisorTests(int a, int expected)
        {
            int actual = Cycles.GetGreatestDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 8, 7)]
        [TestCase(8, 0, 7)]
        [TestCase(-2, 8, 7)]
        [TestCase(8, -2, 7)]
        [TestCase(2, 2, 0)]

        public void GetSumOfNumbersFromTheRangeWhichAreEvenlyDivisibleBy7Tests(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbersFromTheRangeWhichAreEvenlyDivisibleBy7(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        [TestCase(8, 21)]
        [TestCase(15, 610)]

        public void GetFibonacciNumberByIndexTests(int n, int expected)
        {
            int actual = Cycles.GetFibonacciNumberByIndex(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1)]
        [TestCase(2, 1, 1)]
        [TestCase(11, 33, 11)]
        [TestCase(33, 11, 11)]
        [TestCase(100, 99, 1)]

        public void GetGreatestCommonFactorByEuclideanAlgorithmTests(int a, int b, int expected)
        {
            int actual = Cycles.GetGreatestCommonFactorByEuclideanAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(100, 99)]

        //public void GetNByHalfDivisionMethodTests(int n, int expected)
        //{
        //    int actual = Cycles.GetNByHalfDivisionMethod(n);
        //    Assert.AreEqual(expected, actual);
        //}

        [TestCase(1, new int[2] { 0, 1 })]
        [TestCase(2, new int[2] { 1, 0 })]
        [TestCase(0, new int[2] { 1, 0 })]
        [TestCase(-1122, new int[2] { 2, 2 })]
        [TestCase(-2211, new int[2] { 2, 2 })]

        public void GetQuantityOfEvenAndOddDigitsOfANumberTests(int a, int[] expected)
        {
            int[] actual = Cycles.GetQuantityOfEvenAndOddDigitsOfANumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(12, 21)]
        [TestCase(21, 12)]
        //[TestCase(-50, -5)]
        //[TestCase(-123,-321)]

        public void GetInvertedNumberTests(int a, int expected)
        {
            int actual = Cycles.GetInvertedNumber(a);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(0, 0)]

        public void GetNumbersInTheRangeTests(int integer, int[] expected)
        {
            int[] actual = Cycles.GetNumbersInTheRange(integer);
            Assert.AreEqual(expected, actual);
        }
    }
}
