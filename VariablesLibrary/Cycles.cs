using System;

namespace Library
{
    public static class Cycles
    {
        public static int RaiseAToPowerB(int a, int b)
        {
            if (b > 0)
            {
                int result = 1;

                for (int i = 0; i < b; ++i)
                {
                    result *= a;
                }

                return result;
            }

            throw new ArgumentException("B must be a positive integer greater than zero");
        }

        public static int[] GetNumbersDivisibleByA(int a)
        {
            if (a > 0 && a < 1001)
            {
                int count = 0;

                for (int i = 1; i <= 1000; ++i)
                {
                    if (i % a == 0)
                    {
                        count++;
                    }
                }

                int[] array = new int[count];
                int j = 0;

                for (int i = 1; i <= 1000; ++i)
                {
                    if (i % a == 0)
                    {
                        array[j] = i;
                        j++;
                    }
                }

                return array;
            }

            throw new ArgumentOutOfRangeException("A must be in range from 1 to 1000 inclusive");
        }

        public static int GetNumberOfPositiveIntegersWhoseSquareIsLessThanA(int a)
        {
            if (a > 0)
            {
                int count = 0;

                for (int i = 1; i < a; ++i)
                {
                    if ((i * i) < a)
                    {
                        ++count;
                    }
                }

                return count;
            }

            throw new ArgumentException("A must be a positive integer greater than zero");
        }

        public static int GetGreatestDivisor(int a)
        {
            int greatestDivisor = 0;

            if (a > 1)
            {
                for (int i = a - 1; i > 0; --i)
                {
                    if (a % i == 0)
                    {
                        greatestDivisor = i;
                        break;
                    }
                }

                return greatestDivisor;
            }

            throw new ArgumentException("A must be a positive integer greater than 1");
        }

        public static int GetSumOfNumbersFromTheRangeWhichAreEvenlyDivisibleBy7(int a, int b)
        {
            int sum = 0;

            if (a < b)
            {
                for (int i = a; i < b; ++i)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = b; i < a; ++i)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }

            return sum;
        }

        public static int GetFibonacciNumberByIndex(int n)
        {
            if (n > 0)
            {
                int a = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < n; i++)
                {
                    tmp = a;
                    a = b;
                    b += tmp;
                }

                return a;
            }

            throw new ArgumentException("N must be a positive integer greater than zero");
        }

        public static int GetGreatestCommonFactorByEuclideanAlgorithm(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                while (a != b)
                {
                    if (a < b)
                    {
                        b -= a;
                    }
                    else
                    {
                        a -= b;
                    }
                }

                return a;
            }

            throw new ArgumentException("A and B must be a positive integer greater than zero");
        }

        public static int GetNByHalfDivisionMethod(int n)
        {
            if (n > 0)
            {
                int left = 0;
                int right = n;
                int middle = n / 2;
                int basis = n + 1;

                while (basis != n)
                {
                    if (basis > n)
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle;
                    }

                    middle = (right + left) / 2;
                    basis = middle * middle * middle;
                }

                return middle;
            }

            throw new ArgumentException("N must be a positive integer greater than zero");
        }

        public static int[] GetQuantityOfEvenAndOddDigitsOfANumber(int a)
        {
            int countEven = 0;
            int countOdd = 0;

            do
            {
                if (a % 2 == 0)
                {
                    ++countEven;
                }
                else
                {
                    ++countOdd;
                }

                a /= 10;

            } while (a != 0);

            return new int[2] { countEven, countOdd };
        }

        public static int GetInvertedNumber(int a)
        {
            bool isPositive = a >= 0;

            if (a < 0)
            {
                a = -a;
            }

            int temp = a;
            string str = string.Empty;

            do
            {
                temp %= 10;
                str += temp;
                a /= 10;
                temp = a;

            } while (a != 0);

            if (!isPositive)
            {
                str.Insert(0, "-");
            }

            return Convert.ToInt32(str);
        }

        public static int[] GetNumbersInTheRange(int integer)
        {
            if (integer > 2)
            {
                int number;
                int digitOfNumber;
                int count = 0;

                for (int i = 1; i < integer; i++)
                {
                    number = i;
                    int sumOdds = 0;
                    int sumEvens = 0;

                    while (number != 0)
                    {
                        digitOfNumber = number % 10;
                        number /= 10;

                        if ((digitOfNumber % 2) == 1)
                        {
                            sumOdds += digitOfNumber;
                        }
                        else
                        {
                            sumEvens += digitOfNumber;
                        }
                    }

                    if (sumEvens > sumOdds)
                    {
                        ++count;
                    }
                }

                int[] array = new int[count];
                int j = 0;

                for (int i = 1; i < integer; i++)
                {
                    number = i;
                    int sumOdds = 0;
                    int sumEvens = 0;

                    while (number != 0)
                    {
                        digitOfNumber = number % 10;
                        number /= 10;

                        if ((digitOfNumber % 2) == 1)
                        {
                            sumOdds += digitOfNumber;
                        }
                        else
                        {
                            sumEvens += digitOfNumber;
                        }
                    }

                    if (sumEvens > sumOdds)
                    {
                        array[j] = i;
                        j++;
                    }
                }

                return array;
            }

            throw new ArgumentException("Number must be a positive integer greater than 2");

        }

        public static bool CheckDuplicateDigitsInNumbers(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                bool isMutualDigit = false;
                int digitOfA;
                int digitOfB;

                while (a != 0 && !isMutualDigit)
                {
                    digitOfA = a % 10;
                    a /= 10;

                    while (b != 0)
                    {
                        digitOfB = b % 10;
                        b /= 10;

                        if (digitOfA == digitOfB)
                        {
                            isMutualDigit = true;
                            break;
                        }
                    }
                }

                return isMutualDigit;
            }

            throw new ArgumentException("A and B must be a positive integer greater than zero");
        }
    }
}
