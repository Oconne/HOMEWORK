using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightmare_on_Code_Street
{
    class Nightmare_on_Code_Street
    {
        static void Main(string[] args)
        {
            string street = Console.ReadLine();
            int sum = 0;
           int count = 0;

         street=  street.Replace("-","");

            for (int i = 0; i < street.Length; i++)
            {

                if (i % 2 != 0)
                {
                    

                    try { sum = sum + int.Parse(street[i].ToString()); count++;}
                    catch { }

                  //   Console.Write(street[i].ToString() + " ");
                  //  Console.WriteLine(i);
                }
            }

         //  Console.WriteLine(street);
           Console.WriteLine("{0} {1}",count,sum);

            Console.ReadLine();

        }
    }
}
