using System;
using static Methods.Display;

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
            Print(Cycles.Test11(10));
            Print(Cycles.Test12(123, 3456789));
            int[] arr = Arrays.CreateAndFill(11, 10);
            Print(arr);
            Print(Arrays.Test1(arr));
            Print(Arrays.Test2(arr));
            Print(Arrays.Test3(arr));
            Print(Arrays.Test4(arr));
            Print(Arrays.Test5(arr));
            Print(Arrays.Test6(arr));
            Print(Arrays.Test7(arr));
            Print(Arrays.Test8(arr));
            Print(Arrays.Test8_2(arr));
            Print(Arrays.Test9(arr));
            arr = Arrays.CreateAndFill(11, 10);
            Print(arr);
            Print(Arrays.Test10(arr));
            int[,] dArr = DoubleArrays.CreateAndFill(4, 3, 100);
            Print(dArr);
            Print(DoubleArrays.Test1(dArr));
            Print(DoubleArrays.Test3(dArr));
            int[,] dArr2 = DoubleArrays.CreateAndFill(5, 3, 10);
            Print(dArr2);
            Print(DoubleArrays.Test2(dArr2));
            Print(DoubleArrays.Test4(dArr2));
            Print(DoubleArrays.Test6(dArr2));
            Print(DoubleArrays.Test5(dArr2));
            Print(DoubleArrays.Test5(dArr2));
        }
    }
}
