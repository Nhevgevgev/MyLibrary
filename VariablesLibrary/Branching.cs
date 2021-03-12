using System;

namespace Library
{
    public static class Branching
    {
        public static double Calculate(double a, double b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int GetPointQuarter(int x, int y)
        {
            if (x != 0 || y != 0)
            {
                int result = 0;

                if (x > 0 && y > 0)
                {
                    result = 1;
                }
                else if (x > 0 && y < 0)
                {
                    result = 2;
                }
                else if (x < 0 && y < 0)
                {
                    result = 3;
                }
                else if (x < 0 && y > 0)
                {
                    result = 4;
                }

                return result;
            }

            throw new ArgumentException("The point is on the coordinate axis");
        }

        public static void Sort(ref int a, ref int b, ref int c)
        {
            if (a <= b && a <= c)
            {
                if (b >= c)
                {
                    Variables.Swap(ref b, ref c);
                }
            }
            else if (b <= a && b <= c)
            {
                Variables.Swap(ref a, ref b);

                if (b >= c)
                {
                    Variables.Swap(ref b, ref c);
                }
            }
            else if (c <= a && c <= b)
            {
                Variables.Swap(ref a, ref c);

                if (b >= c)
                {
                    Variables.Swap(ref b, ref c);
                }
            }
        }

        public static double GetQuadraticDiscriminant(double a, double b, double c)
        {
            if (a != 0)
            {
                return b * b - 4 * a * c;
            }

            throw new ArgumentException("A should not be equal to zero");
        }

        public static double[] GetSquareEquationRoots(double a, double b, double c)
        {
            double discriminant = GetQuadraticDiscriminant(a, b, c);

            if (a != 0)
            {
                double[] array;

                if (discriminant > 0)
                {
                    double x1 = ((-b + Math.Sqrt(discriminant)) / 2 * a);
                    double x2 = ((-b - Math.Sqrt(discriminant)) / 2 * a);
                    array = new double[2] { x1, x2 };
                }
                else if (discriminant == 0)
                {
                    double x = ((-b + Math.Sqrt(discriminant)) / 2 * a);
                    array = new double[1] { x };
                }
                else
                {
                    array = new double[0] { };
                }

                return array;
            }

            throw new ArgumentException("A should not be equal to zero");
        }

        public static string RightTwoDigitNumberInWords(int number)
        {
            if (number > 9 || number < 100)
            {
                string str = string.Empty;

                if (number > 9 && number < 20)
                {
                    switch (number)
                    {
                        case 10:
                            str += "десять";
                            break;
                        case 11:
                            str += "одиннадцать";
                            break;
                        case 12:
                            str += "двенадцать";
                            break;
                        case 13:
                            str += "тринадцать";
                            break;
                        case 14:
                            str += "четырнадцать";
                            break;
                        case 15:
                            str += "пятнадцать";
                            break;
                        case 16:
                            str += "шестнадцать";
                            break;
                        case 17:
                            str += "семнадцать";
                            break;
                        case 18:
                            str += "восемнадцать";
                            break;
                        case 19:
                            str += "девятнадцать";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (number / 10)
                    {
                        case 2:
                            str += "двадцать ";
                            break;
                        case 3:
                            str += "тридцать ";
                            break;
                        case 4:
                            str += "сорок ";
                            break;
                        case 5:
                            str += "пятьдесят ";
                            break;
                        case 6:
                            str += "шестьдесят ";
                            break;
                        case 7:
                            str += "семьдесят ";
                            break;
                        case 8:
                            str += "восемьдесят ";
                            break;
                        case 9:
                            str += "девяносто ";
                            break;
                        default:
                            break;
                    }

                    switch (number % 10)
                    {
                        case 1:
                            str += "один";
                            break;
                        case 2:
                            str += "два";
                            break;
                        case 3:
                            str += "три";
                            break;
                        case 4:
                            str += "четыре";
                            break;
                        case 5:
                            str += "пять";
                            break;
                        case 6:
                            str += "шесть";
                            break;
                        case 7:
                            str += "семь";
                            break;
                        case 8:
                            str += "восемь";
                            break;
                        case 9:
                            str += "девять";
                            break;
                        default:
                            break;
                    }
                }

                return str;
            }

            throw new ArgumentException("The number must be two-digit");
        }
    }
}
