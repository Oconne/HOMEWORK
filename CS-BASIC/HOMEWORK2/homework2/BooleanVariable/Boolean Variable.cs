using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFemale = false;

            string Female = "female.";
            string Male = "male.";

            Console.WriteLine("I am a "+ (isFemale ?  Female:Male).ToString() );
            Console.ReadLine();
        }
    }
}
