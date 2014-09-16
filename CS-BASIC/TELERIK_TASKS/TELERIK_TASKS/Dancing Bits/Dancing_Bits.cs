using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dancing_Bits
{
    class Dancing_Bits
    {
        static void Main(string[] args)
        {

            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int length = 0;
            long chain = 0;

            for (int i = 0; i < N; i++)
            {

                 long biti = long.Parse(Console.ReadLine());
                 long bitLenth = biti;
                 while (bitLenth > 0) { bitLenth = bitLenth >> 1; length++; }

                 chain = chain << length;
                 chain = chain + biti;
                 length = 0;
   

            }

          
          Console.WriteLine(Convert.ToString( chain,2));
           //  Console.WriteLine(Convert.ToString( dancingBits,2));

          string chainString = Convert.ToString(chain, 2);
          string chainString1 = chainString;


            chainString="0"+chainString+"0";
            Console.WriteLine(chainString);

            string ones="0"+new string('1',K)+"0";
            string zerous=new string('0',K);
            int onesCount=0;
            int zerousCount=0;

           for (int i = 0 ;i < chainString.Length-ones.Length; i++)
           {

               if (chainString.Substring(i, ones.Length) == ones) { onesCount++; }

           }

          for (int i = 0; i < chainString1.Length-zerous.Length+1; i++)
           {

               if (chainString1.Substring(i, zerous.Length) == zerous) { zerousCount++; }

           }



            Console.WriteLine("{0}-{1}-{2}",onesCount,zerousCount, onesCount+zerousCount);
            Console.ReadLine();


        }



    }
}
