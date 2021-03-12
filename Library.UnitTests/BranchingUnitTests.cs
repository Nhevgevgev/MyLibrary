using NUnit.Framework;

namespace Library.UnitTests
{
    public class BranchingUnitTests
    {
        [TestCase(4, 5, -1)]
        [TestCase(5, 0, 5)]
        [TestCase(0, 1, -1)]
        [TestCase(-5, 4, -9)]
        [TestCase(4, -4, 0)]
        [TestCase(0, 0, 0)]

        public void CalculateTests(double a, double b, double expected)
        {
            double actual = Branching.Calculate(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 5, 1)]
        [TestCase(5, -1, 2)]
        [TestCase(-8, -6, 3)]
        [TestCase(-5, 4, 4)]
        [TestCase(4, 4, 1)]

        public void GetPointQuarterTests(int x, int y, int expected)
        {
            double actual = Branching.GetPointQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2, 1, 1, 2, 3)]
        [TestCase(5, -1, 3, -1, 3, 5)]
        [TestCase(-8, 0, 3, -8, 0, 3)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        [TestCase(4, 4, 1, 1, 4, 4)]

        public void SortTests(int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            Branching.Sort(ref a, ref b, ref c);
            int actualA = a;
            int actualB = b;
            int actualC = c;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(3, 2, 1, -8)]
        [TestCase(5, -1, 3, -59)]
        [TestCase(-8, 0, 3, 96)]
        [TestCase(1, 0, 0, 0)]
        [TestCase(4, 4, -1, 32)]

        public void GetQuadraticDiscriminantTests(double a, double b, double c, double expected)
        {
            double actual = Branching.GetQuadraticDiscriminant(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -2, -3, new double[] { 3, -1 })]
        [TestCase(-1, -2, 15, new double[] { -5, 3 })]
        [TestCase(1, 12, 36, new double[] { -6 })]
        [TestCase(5, 2, 6, new double[0] { })]
        [TestCase(2, 10, 0, new double[] { 0, -20 })]

        public void GetSquareEquationRootsTests(double a, double b, double c, double[] expected)
        {
            double[] actual = Branching.GetSquareEquationRoots(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, "одиннадцать")]
        [TestCase(34, "тридцать четыре")]
        [TestCase(50, "пятьдесят ")]
        [TestCase(99, "девяносто девять")]
        [TestCase(10, "десять")]

        public void RightTwoDigitNumberInWordsTests(int number, string expected)
        {
            string actual = Branching.RightTwoDigitNumberInWords(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
