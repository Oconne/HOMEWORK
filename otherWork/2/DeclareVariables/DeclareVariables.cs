﻿// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to 
// represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it.

namespace DeclareVariables
{
    using System;
    using System.Linq;

    public class DeclareVariables
    {
        public static void Main()
        {
            ushort us = 52130;
            sbyte sb = -115;
            int i = 4825932;
            byte b = 97;
            short s = -10000;

            Console.WriteLine(us);
            Console.WriteLine(sb);
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(s);
        }
    }
}
