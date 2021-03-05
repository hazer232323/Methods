using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(Variables.Test5(2,4,3,6));
            Print(Branches.Test1(3, 3));
            Print(Branches.Test2(3, 3));
            Print(Branches.Test3(123,42,56));
            Print(Branches.Test4(4, 22, -2));
            Print(Branches.Test5(23));
            Print(Cycles.Test1(3, 3));
            Print(Cycles.Test2(100));
            Print(Cycles.Test3(26));
            Print(Cycles.Test4(-9));
            Print(Cycles.Test5(7,24));
            Print(Cycles.Test6(7));
            Print(Cycles.Test7(12,36));
            Print(Cycles.Test8(729));
            Print(Cycles.Test9(146598));
            Print(Cycles.Test10(146598));
        }

        static void Print(int a)
        {
            Console.WriteLine(a);
        }
        static void Print(double a)
        {
            Console.WriteLine(a);
        }
        static void Print(string a)
        {
            Console.WriteLine(a);
        }
        static void Print(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} "); 
            }
            Console.WriteLine();
        }
        static void Print(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
    }
}
