using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Methods.Tests
{
    public class CyclesTests
    {
        [TestCase(2, -3, 0.125)]
        [TestCase(3, 3, 27)]
        [TestCase(4, 5, 1024)]
        public static void Test1(decimal a, decimal b, decimal expected)
        {
            decimal actual = Cycles.Test1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(700, new int[] { 700 })]
        public static void Test2(int a, int[] expected)
        {
            int[] actual = Cycles.Test2(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(16, 3)]
        [TestCase(25, 4)]
        [TestCase(36, 5)]
        public static void Test3(double a, int expected)
        {
            int actual = Cycles.Test3(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 3)]
        [TestCase(16, 8)]
        [TestCase(21, 7)]
        public static void Test4(int a, int expected)
        {
            int actual = Cycles.Test4(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, 1, 42)]
        [TestCase(13, 23, 35)]
        [TestCase(34, 43, 77)]
        public static void Test5(int a, int b, int expected)
        {
            int actual = Cycles.Test5(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        public static void Test6(int n, int expected)
        {
            int actual = Cycles.Test6(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 14, 7)]
        [TestCase(2, 22, 2)]
        [TestCase(15, 45, 15)]
        public static void Test7(int a, int b, int expected)
        {
            int actual = Cycles.Test7(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(729, 9)]
        [TestCase(125, 5)]
        [TestCase(27, 3)]
        public static void Test8(double n, int expected)
        {
            int actual = Cycles.Test8(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12345, 3)]
        [TestCase(4457789, 4)]
        [TestCase(11111, 5)]
        public static void Test9(int a, int expected)
        {
            int actual = Cycles.Test9(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(345, 543)]
        [TestCase(5798, 8975)]
        [TestCase(-1234, -4321)]
        public static void Test10(int a, int expected)
        {
            int actual = Cycles.Test10(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, new int[] {2, 4, 6, 8, 12, 14, 16, 18})]
        [TestCase(10, new int[] {2, 4, 6, 8})]
        [TestCase(30, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28})]
        public static void Test11(int n, int[] expected)
        {
            int[] actual = Cycles.Test11(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 3456, "Да")]
        [TestCase(123, 456, "Нет")]
        [TestCase(223345, 66788, "Нет")]
        public static void Test12(int a, int b, string expected)
        {
            string actual = Cycles.Test12(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
