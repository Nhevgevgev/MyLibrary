using System;

namespace Library
{
    public static class Arrays
    {
        public static int[] CreateAndFillWithRandomIntegers(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }

        public static int FindMinValue(int[] array)
        {
            return array[FindMinIndex(array)];
        }

        public static int FindMaxValue(int[] array)
        {
            return array[FindMaxIndex(array)];
        }

        public static int FindMinIndex(int[] array)
        {
            int minIndex = 0;
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public static int GetSumOfElementsWithOddIndexes(int[] array)
        {
            int sum = 0;

            for (int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Variables.Swap(ref array[i], ref array[array.Length - 1 - i]);
            }

            return array;
        }

        public static int GetNumberOfOddElements(int[] array)
        {
            int countOdds = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    ++countOdds;
                }
            }

            return countOdds;
        }

        public static int[] SwapHalves(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Variables.Swap(ref array[i], ref array[array.Length / 2 + i + array.Length % 2]);
            }

            return array;
        }

        public static int[] SortBubbleAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Variables.Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }

        public static int[] SortInsertDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j] > array[j - 1])
                {
                    Variables.Swap(ref array[j], ref array[j - 1]);
                    j--;
                }
            }

            return array;
        }
    }
}
