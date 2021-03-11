using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Methods.Tests
{
    public class DoubleArraysTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 7)]
        public static void Test1(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            int actual = DoubleArrays.Test1(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Test1_WhenArrayEmpty_ArgumentExpection(int mockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => DoubleArrays.Test1(arr));
        }

        [TestCase(1, 8)]
        [TestCase(2, 81)]
        [TestCase(3, 61)]
        public static void Test2(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            int actual = DoubleArrays.Test2(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Test2_WhenArrayEmpty_ArgumentExpection(int mockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => DoubleArrays.Test2(arr));
        }

        [TestCase(1, "0, 0")]
        [TestCase(2, "0, 0")]
        [TestCase(3, "2, 1")]
        public static void Test3(int mockNumber, string expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            string actual = DoubleArrays.Test3(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Test3_WhenArrayEmpty_ArgumentExpection(int mockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => DoubleArrays.Test3(arr));
        }

        [TestCase(1, "2, 2")]
        [TestCase(2, "2, 2")]
        [TestCase(3, "2, 0")]
        public static void Test4(int mockNumber, string expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            string actual = DoubleArrays.Test4(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public static void Test4_WhenArrayEmpty_ArgumentExpection(int mockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => DoubleArrays.Test4(arr));
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(0, 0)]
        public static void Test5(int mockNumber, int expected)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            int actual = DoubleArrays.Test5(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 11)]
        [TestCase(2, 22)]
        [TestCase(3, 33)]
        public static void Test6(int mockNumber, int expectedMockNumber)
        {
            int[,] arr = DoubleArrayMock.GetMock(mockNumber);

            int[,] actual = DoubleArrays.Test6(arr);
            Assert.AreEqual(DoubleArrayMock.GetMock(expectedMockNumber), actual);
        }
    }

    public class DoubleArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch(number)
            {
                case 1:
                    result = new int[,]
                    {
                        {0, 1, 2 },
                        {3, 4, 3 },
                        {6, 7, 8 }
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        {1, 55, 1 },
                        {3, 4, 5 },
                        {6, 7, 81 }
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                        {12, 41, 13 },
                        {13, 14, 55 },
                        {61, 7, 8 }
                    };
                    break;
                case 11:
                    result = new int[,]
                    {
                        {0, 3, 6 },
                        {1, 4, 7 },
                        {2, 3, 8 }
                    };
                    break;
                case 22:
                    result = new int[,]
                    {
                        {1, 3, 6 },
                        {55, 4, 7 },
                        {1, 5, 81 }
                    };
                    break;
                case 33:
                    result = new int[,]
                    {
                        {12, 13, 61 },
                        {41, 14, 7 },
                        {13, 55, 8 }
                    };
                    break;
            }
            return result;
        }
    }
}
