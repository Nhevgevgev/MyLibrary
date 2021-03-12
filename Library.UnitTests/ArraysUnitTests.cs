using NUnit.Framework;
using System;

namespace Library.UnitTests
{
    public class ArraysUnitTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5}, 1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5}, -5)]
        [TestCase(new int[] { 1, 2, 3, 4, 0}, 0)]
        [TestCase(new int[] { 1, 2, 0, -4, -5}, -5)]
        [TestCase(new int[] { -1, -2, 0, 4, 5}, -2)]

        public void FindMinValueTests(int[] array, int expected)
        {
            int actual = Arrays.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 0 }, 4)]
        [TestCase(new int[] { 1, 2, 0, -4, -5 }, 2)]
        [TestCase(new int[] { -1, -2, 0, 4, 5 }, 5)]

        public void FindMaxValueTests(int[] array, int expected)
        {
            int actual = Arrays.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
