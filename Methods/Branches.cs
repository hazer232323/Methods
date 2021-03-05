using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Branches
    {
        public static int Test1(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public static string Test2(int x, int y)
        {
            if (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    return new string("Точка принадлежит I четверти");
                }
                else if (x < 0 && y > 0)
                {
                    return new string("Точка принадлежит II четверти");
                }
                else if (x < 0 && y < 0)
                {
                    return new string("Точка принадлежит III четверти");
                }
                else if (x > 0 && y < 0)
                {
                    return new string("Точка принадлежит IV четверти");
                }
            }
            return new string("Точка не принадлежит ни одной из четвертей");
        }

        public static int[] Test3(int a, int b, int c)
        {
            int temp = 0;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a > c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            return new int[]{ a, b, c};
        }

        public static double[] Test4(double a, double b, double c)
        {
            if(a == 0)
            {
                throw new Exception("a == 0");
            }
            double descriminant = b * b - 4 * a * c;
            if (descriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(descriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(descriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (descriminant == 0)
            {
                double x = (-b) / (2 * a);
                return new double[] { x };
            }
            else
            {
                return new double[0];
            }

        }

        public static string Test5(int a)
        {
            int x = Convert.ToInt32(a);
            string number = "";
            if (x >= 10 && x < 20)
            {
                switch (x)
                {
                    case 10:
                        number = "Десять";
                        break;
                    case 11:
                        number = "Одиннадцать";
                        break;
                    case 12:
                        number = "Двенадцать";
                        break;
                    case 13:
                        number = "Тринадцать";
                        break;
                    case 14:
                        number = "Четырнадцать";
                        break;
                    case 15:
                        number = "Пятнадцать";
                        break;
                    case 16:
                        number = "Шестнадцать";
                        break;
                    case 17:
                        number = "Сеинадцать";
                        break;
                    case 18:
                        number = "Восемнадцать";
                        break;
                    case 19:
                        number = "Девятнадцать";
                        break;
                }
            }
            else if (x >= 20 && x < 100)
            {
                string unitsStr = "";
                string dozensStr = "";
                int units = x % 10;
                int dozens = x / 10;
                switch (units)
                {
                    case 0:
                        unitsStr = "";
                        break;
                    case 1:
                        unitsStr = "один";
                        break;
                    case 2:
                        unitsStr = "два";
                        break;
                    case 3:
                        unitsStr = "три";
                        break;
                    case 4:
                        unitsStr = "четыре";
                        break;
                    case 5:
                        unitsStr = "пять";
                        break;
                    case 6:
                        unitsStr = "шесть";
                        break;
                    case 7:
                        unitsStr = "семь";
                        break;
                    case 8:
                        unitsStr = "восемь";
                        break;
                    case 9:
                        unitsStr = "девять";
                        break;
                }
                switch (dozens)
                {
                    case 2:
                        dozensStr = "Двадцать";
                        break;
                    case 3:
                        dozensStr = "Тридцать";
                        break;
                    case 4:
                        dozensStr = "Сорок";
                        break;
                    case 5:
                        dozensStr = "Пятьдесят";
                        break;
                    case 6:
                        dozensStr = "Шестьдесят";
                        break;
                    case 7:
                        dozensStr = "Семьдесят";
                        break;
                    case 8:
                        dozensStr = "Восемьдесят";
                        break;
                    case 9:
                        dozensStr = "Девяносто";
                        break;
                }
                number = dozensStr +
                    unitsStr;

            }
            else
            {
                throw new Exception("Число не двухзначное");
            }
            return number;
        }
    }
}
