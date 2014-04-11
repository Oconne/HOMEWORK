using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Odd_Number1
{
    class Odd_Number1
    {
        static void Main(string[] args)
        {


 
            List<BigInteger> list = new List<BigInteger>();
            List<BigInteger> listD = new List<BigInteger>();
            List<BigInteger[]> listCount = new List<BigInteger[]>();




            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                list.Add( BigInteger.Parse(Console.ReadLine()));
            }

            listD = list.Distinct().ToList();

            int k = 0;
            foreach (BigInteger item in listD)
            {
                listCount.Add(new BigInteger[]{item,0});
               
                foreach (BigInteger item1 in list)
                {
                    if (item == item1) { listCount[k][1]++; }
                }
                
                  k++;
            }


            BigInteger maxOddCount = 0;
            BigInteger maxOdd = 0;

             foreach (BigInteger[] item in listCount)
            {
                if (item[1] > maxOddCount && ((item[1] & 1) == 1)) { maxOddCount = item[1]; maxOdd=item[0];}
            }



             //foreach (var item in listCount)
             //{
             //    Console.WriteLine("{0}--{1}", item[0], item[1]);
             //}

             Console.WriteLine(maxOdd);
          


            Console.ReadLine();
        }
    }
}
