using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            bool desiredNumber =firstNumber >=secondNumber;
            Console.WriteLine(desiredNumber? firstNumber:secondNumber);
           // Console.WriteLine(Math.Max(firstNumber, secondNumber));
            Console.ReadLine();
        }
    }
}
