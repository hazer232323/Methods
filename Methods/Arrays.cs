using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Arrays
    {
        public static int [] CreateAndFill(int a, int max)
        {
            if(a == 0)
            {
                throw new Exception("a == 0");
            }
            if (max < 0)
            {
                throw new Exception("max < 0");
            }
            int[] arr = new int[a];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(max);
            }
            return arr;
        }
        public static int Test1(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("arr.Length == 0");
            //Найти минимальный элемент массива
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int Test2(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("arr.Length == 0");
            //Найти максимальный элемент массива
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int Test3(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("arr.Length == 0");
            //Найти индекс минимального элемента массива
            int min = arr[0];
            int minIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int Test4(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("arr.Length == 0");
            //Найти индекс максимального элемента массива
            int max = arr[0];
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int Test5(int[] arr)
        {
            if (arr.Length == 0)
                throw new ArgumentException("arr.Length == 0");
            //Посчитать сумму элементов массива с нечетными индексами
            int summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    summ += arr[i];
                }
            }
            return summ;
        }
        public static int[] Test6(int[] arr)
        {
            //Сделать реверс массива (массив в обратном направлении)
            int i = 0;
            int temp = 0;
            while (i < arr.Length - 1 - i)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
                i++;
            }
            return arr;
        }
        public static int Test7(int[] arr)
        {
            //Посчитать количество нечетных элементов массива
            int num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    num++;
                }
            }
            return num;
        }
        public static int[] Test8(int[] arr)
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312
            int i = 0;
            int temp = 0;
            int delta = 0;
            if (arr.Length % 2 != 0)
            {
                delta = 1;
            }
            while (i < arr.Length - 1 - i)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length / 2 + i + delta];
                arr[arr.Length / 2 + i + delta] = temp;
                i++;
            }
            return arr;
        }
        public static int[] Test8_2(int[] arr)
        {
            int i = arr.Length/2 - 1;
            int temp = 0;
            int j = 0;
            while (i >= 0)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - j];
                arr[arr.Length - 1 - j] = temp;
                i--;
                j++;
            }
            return arr;
        }
        public static int[] Test9(int[] arr)
        {
            //Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором (Select) или вставками (Insert))
            //В моем случае это пузырьком
            int len = arr.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        /*int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;*/
                    }
                }
            }
            return arr;
        }
        public static int[] Test10(int[] arr)
        {
            //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select) или вставками (Insert))
            //В моем случае выбором
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int indexOfMax = i;
                for(int j = i; j < arr.Length; j++)
                {
                    if(arr[indexOfMax] < arr[j])
                    {
                        indexOfMax = j;
                    }
                }
                Swap(ref arr[i], ref arr[indexOfMax]);
                /*int tmp = arr[i];
                arr[i] = arr[indexOfMax];
                arr[indexOfMax] = tmp;*/
            }
            return arr;
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
