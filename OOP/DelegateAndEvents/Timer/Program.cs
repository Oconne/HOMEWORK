using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timer
{
    class Program
    {

        public static void WriteSeconds(string str)
        {
            Console.WriteLine(str);
        }


        static void Main(string[] args)
        {



            AsyncTimer at = new AsyncTimer(WriteSeconds, 2000, 0);
            at.Run();


        Console.WriteLine("Press the Enter key to exit the program... ");
        Console.ReadLine();
        Console.WriteLine("Terminating the application...");


        }


    }
}
