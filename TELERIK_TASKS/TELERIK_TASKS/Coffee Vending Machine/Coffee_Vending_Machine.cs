using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Vending_Machine
{
    class Coffee_Vending_Machine
    {
        static void Main(string[] args)
        {

            decimal[]  coins = { 0.05m, 0.10m, 0.20m, 0.50m,  1.00m  };
                int[]  trays = {int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),
                               int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),
                               int.Parse(Console.ReadLine())};

        List<decimal>  coinSet = new List<decimal>();

                                  for (int i = 0; i <coins.Length; i++)
                                  {

                                      for (int k = 0; k < trays[i]; k++)
                                      {
                                          coinSet.Add(coins[i]);
                                          
                                      }


                                  }


              decimal  A = decimal.Parse(Console.ReadLine()),  P = decimal.Parse(Console.ReadLine()),  R = A - P, traysum;

                           traysum=traySum(coins, trays);

                          if (R < 0)
                          {
                              Console.WriteLine("More {0}", -R);
                          }
                          else if (traysum < P)
                          {
                              Console.WriteLine("No {0}", P - traysum);
                          }
                          else 
                          {

                              foreach (var item in allSums(getAllCombinations(coinSet)))
                              {
                                  if (item == R) { Console.WriteLine("Yes {0}", traysum - R); Console.ReadLine();return; }
                              }
                             

                          }


                          //foreach (var item in allSums( getAllCombinations(coinSet)))
                          //{
                          //    Console.Write(item + " ");
                          //}



              Console.ReadLine();

        }


        public static decimal traySum(decimal[] coins_,int[] trays_) {

            decimal sum = 0;

                        for (int i = 0; i < trays_.Length; i++)
                        {
                            sum += trays_[i] * coins_[i];
                        }

           return sum;
        }


        public static List<List<decimal>> getAllCombinations(List<decimal> source)
        {

            List<List<decimal>> result = new List<List<decimal>>();

            for (int i = 0; i < Math.Pow(2, source.Count); i++)
            {

                List<decimal> combination = new List<decimal>();

                for (int j = 0; j < source.Count; j++)
                {
                    if ((i & (1 << (source.Count - j - 1))) != 0)
                    {

                        combination.Add(source[j]);

                    }
                }

                result.Add(combination);
            }

            return result;

        }

        public static List<decimal> allSums( List<List<decimal>> set) {

            List<decimal> all = new List<decimal>();

            foreach (var item in set)
            {
                decimal sum = 0;
                foreach (var item1 in item)
                {
                    sum += item1;
                }
                all.Add(sum);

            }

            return all;
        }



    }
}
