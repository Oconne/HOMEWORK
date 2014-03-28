using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferencebetweenDates
{
    class DifferencebetweenDates
    {
        static void Main(string[] args)
        {


       Console.WriteLine(     diffDate(DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()))  );
            Console.ReadLine();
        }

public static double diffDate(DateTime d1,DateTime d2){

    double days=0;
    days = (d2 - d1).TotalDays;

    return days;

    
    }


    }
}
