using NUnit.Framework;
using System;

namespace Library.UnitTests
{
    public class VariablesUnitTests
    {
        [TestCase(4, 5, 45)]
        [TestCase(5, 0, -5)]
        [TestCase(0, 1, 1)]
        [TestCase(-5, 4, -1)]
        [TestCase(4, -4, -4.5)]

        public void SolveEquationTests(double a, double b, double expected)
        {
            double actual = Variables.SolveEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(0, 0)]
        [TestCase(7, 7)]
        [TestCase(4, 4)]
        [TestCase(-4, -4)]

        public void SolveEquationNegativeTests(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveEquation(a, b));
        }

        [TestCase(4, 5, 5, 4)]
        [TestCase(6, 2, 2, 6)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(0, 9, 9, 0)]
        [TestCase(3, 0, 0, 3)]

        public void SwapTests(int a, int b, int expectedA, int expectedB)
        {
            Variables.Swap(ref a, ref b);
            int actualA = a;
            int actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(4, 2, new double[] { 2, 0 })]
        [TestCase(5, 5, new double[] { 1, 0 })]
        [TestCase(4, 8, new double[] { 0.5, 4 })]
        [TestCase(-2, 1, new double[] { -2, 0 })]
        [TestCase(4, -5, new double[] { -0.8, 4 })]

        public void GetADividedByBAndRemainderAfterDivisionOfAByBTests(double a, double b, double[] expected)
        {
            double[] actual = Variables.GetADividedByBAndRemainderAfterDivisionOfAByB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        [TestCase(-6, 0)]
        [TestCase(-8, 0)]

        public void GetADividedByBAndRemainderAfterDivisionOfAByBNegativeTests(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.GetADividedByBAndRemainderAfterDivisionOfAByB(a, b));
        }

        [TestCase(1, 2, 4, 2)]
        [TestCase(4, 0, 1, 0.25)]
        [TestCase(9, 9, 0, -1)]
        [TestCase(-8, 1, 9, -1)]
        [TestCase(2, -5, 10, 7.5)]

        public void GetLinearEquationSolutionTests(double a, double b, double c, double expected)
        {
            double actual = Variables.GetLinearEquationSolution(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 7)]
        [TestCase(0, 2, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 4, -1)]
        [TestCase(0, -4, 5)]

        public void GetLinearEquationSolutionNegativeTests(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.GetLinearEquationSolution(a, b, c));
        }

        [TestCase(1, 1, 2, 2, 1, 0)]
        [TestCase(4, 0, 2, -2, 1, -4)]
        [TestCase(0, 5, -1, 4, 1, 5)]
        [TestCase(8, -1, 0, 1, -0.25, 1)]
        [TestCase(-2, 5, 6, 0, -0.625, 3.75)]

        public void GetStraightLineEquationTests(double x1, double y1, double x2, double y2, double expectedA, double expectedB)
        {
            (double actualA, double actualB) = Variables.GetStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(0, 5, 0, 3)]
        [TestCase(1, 2, 1, 4)]
        [TestCase(2, 2, 2, 2)]
        [TestCase(3, 3, 3, 3)]
        [TestCase(-1, 2, -1, 4)]

        public void GetStraightLineEquationNegativeTests(double x1, double y1, double x2, double y2)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetStraightLineEquation(x1, y1, x2, y2));
        }
    }
}