using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Variables
    {
        public static double Test1(double a, double b)
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль решение(5 * A + B ^ 2) / (B - A)
            double result = (5 * a + b * b) / (b - a);
            return result;
        }

        public static int[] Test3(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль результат деления A на B и остаток от деления.
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
            //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A*X+B=C.
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            double x = (c - b) / a;
            return x;
        }

        public static string Test5(double x1, double x2, double y1, double y2)
        {
            //Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            return new string($"y= {a}x + {b}");
        }
    }
}
