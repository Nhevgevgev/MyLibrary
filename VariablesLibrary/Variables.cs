using System;

namespace Library
{
    public static class Variables
    {
        public static double SolveEquation(double a, double b)
        {
            if (a != b)
            {
                return (5 * a + b * b) / (b - a);
            }

            throw new ArgumentException("A should not be equal to B");
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static double[] GetADividedByBAndRemainderAfterDivisionOfAByB(double a, double b)
        {
            if (b != 0)
            {
                double c = a % b;
                a /= b;

                return new double[2] { a, c };
            }

            throw new DivideByZeroException("B should not be equal to zero");
        }

        public static double GetLinearEquationSolution(double a, double b, double c)
        {
            if (a != 0)
            {
                return (c - b) / a;
            }

            throw new DivideByZeroException("A should not be equal to zero");
        }

        public static (double a, double b) GetStraightLineEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 != x2)
            {
                double a = (y2 - y1) / (x2 - x1);
                double b = (y2 - ((y2 - y1) / (x2 - x1)) * x2);

                return (a, b);
            }

            throw new ArgumentException("X1 should not be equal to X2");
        }
    }
}
