using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Methods.Tests
{
    public class ArraysTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 13)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 54)]
        public static void Test1(int[] arr, int expected)
        {
            int actual = Arrays.Test1(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 51)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 531)]
        public static void Test2(int[] arr, int expected)
        {
            int actual = Arrays.Test2(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 2)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 4)]
        public static void Test3(int[] arr, int expected)
        {
            int actual = Arrays.Test3(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 4)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 2)]
        public static void Test4(int[] arr, int expected)
        {
            int actual = Arrays.Test4(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 66)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 573)]
        public static void Test5(int[] arr, int expected)
        {
            int actual = Arrays.Test5(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 4, 2, 6, 7 }, new int[] { 7, 6, 2, 4 })]
        [TestCase(new int[] { -88, 6, 12 }, new int[] { 12, 6, -88 })]
        public static void Test6(int[] arr, int[] expected)
        {
            int[] actual = Arrays.Test6(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 14, 22, 13, 44, 51 }, 2)]
        [TestCase(new int[] { 223, 142, 531, 431, 54 }, 3)]
        public static void Test7(int[] arr, int expected)
        {
            int actual = Arrays.Test7(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {4, 5, 3, 1, 2 })]
        [TestCase(new int[] { 4, 2, 6, 7 }, new int[] { 6, 7, 4, 2 })]
        [TestCase(new int[] { -88, 6, 12, 1 }, new int[] { 12, 1, -88, 6 })]
        public static void Test8(int[] arr, int[] expected)
        {
            int[] actual = Arrays.Test8(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 7, 4, 5 }, new int[] { 1, 2, 4, 5, 7 })]
        [TestCase(new int[] { 4, 2, 6, 7 }, new int[] { 2, 4, 6, 7 })]
        [TestCase(new int[] { -88, 6, 12, 1 }, new int[] { -88, 1, 6, 12 })]
        public static void Test9(int[] arr, int[] expected)
        {
            int[] actual = Arrays.Test9(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 7, 4, 5 }, new int[] { 7, 5, 4, 2, 1 })]
        [TestCase(new int[] { 4, 2, 6, 7 }, new int[] { 7, 6, 4, 2 })]
        [TestCase(new int[] { -88, 6, 12, 1 }, new int[] { 12, 6, 1, -88 })]
        public static void Test10(int[] arr, int[] expected)
        {
            int[] actual = Arrays.Test10(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
