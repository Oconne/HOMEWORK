using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements_Homework
{
    class OddOrEven
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a number:");
            int number = int.Parse(Console.ReadLine());

            if (number%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
