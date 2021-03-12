using System;

namespace Library
{
    public static class TwoDimensionalArrays
    {
        public static int[,] CreateAndFillWithRandomIntegers(int rows, int columns, int minValue, int maxValue)
        {
            int[,] array = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                }
            }

            return array;
        }

        public static int FindMinValue(int[,] array)
        {
            var indexes = FindMinIndex(array);
            return array[indexes[0], indexes[1]];
        }

        public static int FindMaxValue(int[,] array)
        {
            var indexes = FindMaxIndex(array);
            return array[indexes[0], indexes[1]];
        }

        public static int[] FindMinIndex(int[,] array)
        {
            int[] minIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[minIndex[0], minIndex[1]] > array[i, j])
                    {
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }

            return minIndex;
        }

        public static int[] FindMaxIndex(int[,] array)
        {
            int[] maxIndex = new int[2];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[maxIndex[0], maxIndex[1]] < array[i, j])
                    {
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }

            return maxIndex;
        }

        //public static int[,] ReverseArrayDiagonally(int[,] array)
        //{
        //    int m = array.GetLenght(0);

        //    for (int row = 0; row < m - 1; row++)
        //        for (int col = 0; col < m - 1 - row; col++)
        //        {
        //            var tmp = array[row, col];
        //            array[row, col] = array[col, row];
        //            array[col, row] = tmp;
        //        }
        //    for (int row = 0; row < m / 2; row++)
        //    {
        //        var tmp = array[row, m - 1 - row];
        //        array[row, m - 1 - row] = array[m - 1 - row, row];
        //        array[m - 1 - row, row] = tmp;
        //    }
        //}
    }
}
