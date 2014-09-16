// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

namespace ComparingFloats
{
    using System;

    class CompareFloats
    {
        static void Main()
        {
            double a = 5.3;
            double b = 6.01;

            double esp = 0.000001;
            bool equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);

            a = 5.00000001;
            b = 5.00000003;
            equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);

            a = 5.00000005;
            b = 5.00000001;
            equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);

            a = -0.0000007;
            b = 0.00000007;
            equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);

            a = -4.999999;
            b = -4.999998;
            equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);
            
            a = 4.999999;
            b = 4.999998;
            equal = (Math.Abs(a - b) < esp);
            Console.WriteLine(equal);
            Console.ReadLine();
        }
    }
}
