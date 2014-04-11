using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Date
{
    class Next_Date
    {
        static void Main(string[] args)
        {

            int d=int.Parse(Console.ReadLine()),m= int.Parse(Console.ReadLine()),y=int.Parse(Console.ReadLine());

            DateTime data = new DateTime(y, m, d); data= data.AddDays(1);
            Console.WriteLine("{0:d.M.yyyy}",data);

            Console.ReadLine();

        }




    }
}
