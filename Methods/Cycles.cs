using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Cycles
    {
        public static int Test1(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            int result = 0;
            if (b == 0)
            {
                result = 1;
                return result;
            }
            if (b < 0)
            {
                result = a;
                for (int i = 1; i < Math.Abs(b); i++)
                {
                    result *= a;
                }
                return 1 / result;
            }
            result = a;
            for (int i = 1; i < b; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int[] Test2(int a)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            int length = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    length++;
                }
            }
            int[] result = new int[length];
            int n = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result[n] = i;
                    n++;
                }
            }
            return result;
        }

        public static int Test3(double a)
        {
            //Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, квадрат которых меньше A.
            if (a < 0)
            {
                throw new Exception("a < 0");
            }
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            int result = 0;
            double sqrt = Math.Sqrt(a);
            for (double i = 1; i < sqrt; i++)
            {
                result++;
            }
            return result;
        }
        public static int Test4(int a)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            if (a == 0)
            {
                throw new Exception("a == 0");
            }
            int i = Math.Abs(a);
            do
            {
                i--;
            } while (a % i != 0);
            if(a < 0)
            {
                return -1 * i;
            }
            return i;
        }

        public static int Test5(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
            if (a == 0 && b == 0)
            {
                throw new Exception("a == 0 и b == 0");
            }
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            return result;
        }

        public static int Test6(int n)
        {
            //Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. В ряду фибоначчи каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
            if (n == 0)
            {
                throw new Exception("n == 0");
            }
            int result = 0;
            if (n < 1)
            {
                throw new Exception("n < 1");
            }
            else
            {
                int first = 1;
                int second = 1;
                

                int i = 2;
                while (i < n)
                {
                    result = first + second;
                    first = second;
                    second = result;
                    i++;
                }
            }
            return result;
        }
        public static int Test7(int a, int b)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            if (a == 0 && b == 0)
            {
                throw new Exception("a == 0 и b == 0");
            }
            while (b != 0)
            {
                b = a % (a = b);
            }
            return(Math.Abs(a));
        }

        public static int Test8(double n)
        {
            //Пользователь вводит целое положительное число, которое является кубом целого числа N. Найдите число N методом половинного деления.
            if (n < 0)
            {
                throw new Exception("n < 0");
            }
            if (n == 0)
            {
                throw new Exception("n == 0");
            }
            double left = 0d;
            double right = n;
            double middle = right;
            double delta = 0.01d;
            while (!(n <= Math.Pow((middle + delta),3) && n >= Math.Pow((middle - delta),3)))
            {
                if (middle * middle * middle > n)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
            }
            return Convert.ToInt32(middle);
        }

        public static int Test9(int a)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            int summ = 0;
            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    summ += 1;
                }
                a /= 10;
            }
            return summ;
        }
        public static int Test10(int a)
        {
            //Пользователь вводит 1 число. Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.
            int result = 0;
            while (a != 0)
            {
                if (result != 0)
                {
                    result *= 10;
                }
                int i = a % 10;
                result += i;
                a /= 10;
            }
            return result;
        }
        public static int[] Test11(int n)
        {
            //Пользователь вводит целое положительное  число (N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            if (n < 0)
            {
                throw new Exception("n < 0");
            }
            if (n == 0)
            {
                throw new Exception("n == 0");
            }
            int length = 0;
            for (int i = 1; i < n; i++)
            {
                int number = i;
                int chtn = 0;
                int nchtn = 0;
                while (number > 0)
                {
                    int temp = number % 10;
                    if (temp % 2 == 0)
                    {
                        chtn += temp;
                    }
                    else
                    {
                        nchtn += temp;
                    }
                    number /= 10;
                }
                if (chtn > nchtn)
                {
                    length = length + 1;
                }
            }
            int[] res = new int[length];
            int l = 0;
            for (int i = 1; i < n; i++)
            {
                int number = i;
                int chtn = 0;
                int nchtn = 0;
                while (number > 0)
                {
                    int temp = number % 10;
                    if (temp % 2 == 0)
                    {
                        chtn += temp;
                    }
                    else
                    {
                        nchtn += temp;
                    }
                    number /= 10;
                }
                if (chtn > nchtn)
                {
                    res[l] = i;
                    l++;
                }      
            }
            return res;
        }
        public static string Test12(int a, int b)
        {
            //Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            int num1 = Math.Abs(a);
            int num2 = Math.Abs(b);
            bool same = false;
            while (num1 > 0)
            {
                int temp1 = num1 % 10;
                while (num2 > 0)
                {
                    int temp2 = num2 % 10;
                    same = (temp1 == temp2);
                    num2 /= 10;
                }
                num1 /= 10;
            }
            if(same == false)
            {
                return new string("Нет");
            }
            return new string("Да");
        }
    }
}
