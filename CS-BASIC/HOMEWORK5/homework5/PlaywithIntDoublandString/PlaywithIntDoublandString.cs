using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywithIntDoublandString
{
    class PlaywithIntDoublandString
    {
        static void Main(string[] args)
        {
            Console.Write(
           @"Please choose a type:
1 --> int
2 --> double
3 --> string" + "\n"
           );

            byte choise = byte.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1: Console.WriteLine("Please enter an int:");Console.WriteLine( int.Parse (Console.ReadLine())+1); break;
                case 2: Console.WriteLine("Please enter a double:"); Console.WriteLine(double.Parse(Console.ReadLine()) + 1); break;
                case 3: Console.WriteLine("Please enter a string:"); Console.WriteLine(Console.ReadLine() + "*"); break;
                default: Console.WriteLine("Not correct choice!"); break;

            }


            Console.ReadLine();


        }
    }
}
