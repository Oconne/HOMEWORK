using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine()); ;
            DateTime currentDay = DateTime.Now;
            TimeSpan span = currentDay - birthDay;
            int yourAgeNow = (zeroTime + span).Year - 1;

            Console.WriteLine(yourAgeNow);
            Console.WriteLine(yourAgeNow+10);
           
            Console.ReadLine();

        }
    }
}
