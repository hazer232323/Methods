using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Methods.Tests
{
    public class BranchesTests
    {
        [TestCase(3, 3, 9)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 9, -6)]
        public static void Test1(int a, int b, int expected)
        {
            int actual = Branches.Test1(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, "Точка принадлежит I четверти")]
        [TestCase(3, -5, "Точка принадлежит IV четверти")]
        [TestCase(0, -5, "Точка не принадлежит ни одной из четвертей")]
        public static void Test2(int x, int y, string expected)
        {
            string actual = Branches.Test2(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(8,5,3, new int[] {3, 5, 8})]
        [TestCase(4, 7, 1, new int[] { 1, 4, 7 })]
        [TestCase(-2, -12, 4, new int[] { -12, -2, 4 })]
        public static void Test3(int a, int b, int c, int[] expected)
        {
            int[] actual = Branches.Test3(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, -3, new double[] {0.5, -3})]
        [TestCase(4, 21, 5, new double[] { -0.25, -5 })]
        [TestCase(2, 9, 7, new double[] { -1, -3.5 })]
        public static void Test4(double a, double b, double c, double[] expected)
        {
            double[] actual = Branches.Test4(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(21, "Двадцатьодин")]
        [TestCase(99, "Девяностодевять")]
        [TestCase(45, "Сорокпять")]
        public static void Test5(int a, string expected)
        {
            string actual = Branches.Test5(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
