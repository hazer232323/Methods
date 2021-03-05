using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Cycles
    {
        public static int Test1(int a, int b)
        {
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
            if(a == 0)
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
            if(a < 0)
            {
                throw new Exception("a < 0");
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
            while (b != 0)
            {
                b = a % (a = b);
            }
            return(Math.Abs(a));
        }

        public static int Test8(double n)
        {
            if(n < 0)
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
    }
}
