using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Display
    {
        public static void Print(int a)
        {
            Console.WriteLine(a);
        }
        public static void Print(double a)
        {
            Console.WriteLine(a);
        }
        public static void Print(decimal a)
        {
            Console.WriteLine(a);
        }
        public static void Print(string a)
        {
            Console.WriteLine(a);
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void Print(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Print(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
