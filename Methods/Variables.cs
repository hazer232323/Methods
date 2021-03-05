using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Variables
    {
        public static double Test1(double a, double b)
        {
            double result = (5 * a + b * b) / (b - a);
            return result;
        }

        public static int[] Test3(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b == 0");
            }
            int result = a / b;
            int ostatok = a % b;
            return new int[] { result, ostatok };
        }

        public static double Test4(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            double x = (c - b) / a;
            return x;
        }

        public static string Test5(double x1, double x2, double y1, double y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            return new string($"y= {a}x + {b}");
        }
    }
}
