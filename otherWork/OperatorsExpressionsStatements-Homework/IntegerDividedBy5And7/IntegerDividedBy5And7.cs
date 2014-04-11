using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDividedBy5And7
{
    class IntegerDividedBy5And7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            int givenInteger = int.Parse(Console.ReadLine());
            bool expression = ((givenInteger % 7 == 0) & (givenInteger % 5 == 0));
            Console.WriteLine("The number can be divided (without remainder)\n by 7 and 5 in the same time-> {0}", expression);
        }
    }
}
