using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class DoubleArrays
    {
        public static int[,] CreateAndFill(int a, int b, int max)
        {
            if (a <= 0)
            {
                throw new Exception("a <= 0");
            }
            if (b <= 0)
            {
                throw new Exception("b <= 0");
            }
            if (max < 0)
            {
                throw new Exception("max < 0");
            }
            int[,] arr = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(max);
                }    
            }
            return arr;
        }
        public static int Test1(int[,] arr)
        {
            //Найти минимальный элемент массива
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }
        public static int Test2(int[,] arr)
        {
            //Найти максимальный элемент массива
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        public static string Test3(int[,] arr)
        {
            //Найти индекс минимального элемента массива
            int min = arr[0, 0];
            string minIndex = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        minIndex = Convert.ToString($"{i}, {j}"); 
                    }
                }
            }
            return minIndex;
        }
        public static string Test4(int[,] arr)
        {
            //Найти индекс максимального элемента массива
            int max = arr[0, 0];
            string maxIndex = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        maxIndex = Convert.ToString($"{i}, {j}");
                    }
                }
            }
            return maxIndex;
        }
        public static int Test5(int[,] arr)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно
            int l = 0;
            int y = arr.GetLength(0) - 1;
            int x = arr.GetLength(1) - 1;
            if(arr[0, 0] > arr[0, 1] && arr[0, 0] > arr[1, 0])
            {
                l++;
            }
            if (arr[0, x] > arr[0, x - 1] && arr[0, x] > arr[1, x])
            {
                l++;
            }
            if (arr[y, x] > arr[y, x - 1] && arr[y, x] > arr[y - 1, x])
            {
                l++;
            }
            if (arr[y, 0] > arr[y, 1] && arr[y, 0] > arr[y - 1, 0])
            {
                l++;
            }
            for(int i = 1; i < y; i++)
            {
                for(int j = 1; j < x; j++)
                {
                    if(arr[i, j] > arr[i - 1, j] && arr[i,j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i + 1, j])
                    {
                        l++;
                    }
                }
            }
            for(int i = 1; i < y; i++)
            {
                if(arr[i, 0] > arr[i, 1] && arr[i, 0] > arr[i - 1, 0] && arr[i, 0] > arr[i + 1, 0])
                {
                    l++;
                }
                if (arr[i, x] > arr[i, x-1] && arr[i, x] > arr[i - 1, x] && arr[i, x] > arr[i + 1, x])
                {
                    l++;
                }
            }

            for(int j = 1; j < x; j++)
            {
                if(arr[0, j] > arr[1, j] && arr[0, j] > arr[0, j - 1] && arr[0, j] > arr[0, j + 1])
                {
                    l++;
                }
                if (arr[y, j] > arr[y - 1, j] && arr[y, j] > arr[y, j - 1] && arr[y, j] > arr[y, j + 1])
                {
                    l++;
                }
            }

            return l;
        }
        public static int[,] Test6(int[,] arr)
        {
            //Отразите массив относительно его главной диагонали
            int[,] retArr = new int[arr.GetLength(1), arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    retArr[j, i] = arr[i, j];
                }
            }
            return retArr;
        }
    }
}
