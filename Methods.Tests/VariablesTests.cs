using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Methods.Tests
{
    public class VariablesTests
    {
        [TestCase(10d, 5d, -15d)]
        [TestCase(-3d, 5d, 1.25d)]
        [TestCase(125d, -500d, -401d)]
        [TestCase(125d, -399d, -305.011d)]
        public static void Test1(double a, double b, double expected)
        {
            double actual = Variables.Test1(a, b);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(5, 3, 3, 5)]
        [TestCase(41, 12, 12, 41)]
        [TestCase(125, -500, -500, 125)]
        public static void Test2(int a, int b, int expectedA, int expectedB)
        {
            Variables.Test2(ref a, ref b);
            int actualA = a;
            int actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(10, 2, new int[] { 5, 0 })]
        [TestCase(9, 2, new int[] { 4, 1 })]
        [TestCase(-90, 4, new int[] { -22, -2 })]
        public static void Test3(int a, int b, int[] expected)
        {
            int[] actual = Variables.Test3(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 0)]
        [TestCase(155, 0)]
        [TestCase(14120, 0)]
        public static void Test3_WhenDivideByZero_DivideByZeroExpection(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.Test3(a, b));
        }

        [TestCase(2, 3, 5, 1)]
        [TestCase(4, 7, 5, -0.5d)]
        [TestCase(6, -3, 9, 2)]
        [TestCase(11, 3, 7, 0.363)]
        public static void Test4(double a, double b, double c, double expected)
        {
            double actual = Variables.Test4(a, b, c);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(0, 1, 2)]
        [TestCase(0, 13, 21)]
        [TestCase(0, 15, 211)]
        public static void Test4_WhenDivideByZero_DivideByZeroExpection(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() => Variables.Test4(a, b, c));
        }


        [TestCase(2, 4, 3, 6, "y= 1,5x + 0")]
        [TestCase(2, 6, 8, -6, "y= -3,5x + 15")]
        [TestCase(3, 6, 9, 3, "y= -2x + 15")]
        public static void Test5(double x1, double x2, double y1, double y2, string expected)
        {
            string actual = Variables.Test5(x1, x2, y1, y2);

            Assert.AreEqual(expected, actual);
        }

    }
} 