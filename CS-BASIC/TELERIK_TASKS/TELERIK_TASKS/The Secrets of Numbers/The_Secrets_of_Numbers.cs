using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace The_Secrets_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


                   string   str = Console.ReadLine();
               BigInteger   N = BigInteger .Parse(str);
                            //if (N < 0) { N = -N; }

             List<string>   NumberIN =   str.Select(c => c.ToString()).ToList();
                List<int>   Numbers = NumberIN.Select(s => int.Parse(s)).ToList();
               BigInteger   secretSum = 0,  lastDigit,  R;
                     char   FirstChar;
                          
                           Numbers.Reverse();
                           Numbers.Insert(0, 0);

                                for (int i = 0; i <Numbers.Count ; i++)
                                {
                                    
                                    if (i % 2 == 0)
                                    {
                                        secretSum += ((BigInteger)Math.Pow(Numbers[i], 2)) * i;

                                    }
                                    else 
                                    {

                                        secretSum +=  Numbers[i]*((BigInteger)Math.Pow(i, 2)) ;
                
                                    }
                                }


                                lastDigit = secretSum % 10; if (lastDigit == 0) { 
                                             Console.WriteLine("{0}\n{1} {2}", secretSum,N, "has no secret alpha-sequence");
                                             Console.ReadLine();
                                             return;
                                             }

                                R = secretSum % 26;
                                int k = 0;
                                Console.WriteLine(secretSum);

                                for (int i = 0; i < lastDigit; i++)
                                {

                                    if (64 + R + 1 + i > 90)
                                    {

                                        FirstChar = (char)(65 +k);
                                        Console.Write(FirstChar);
                                        k++;
                                    }
                                    else
                                    {
                                        FirstChar = (char)(64 + R + 1 + i);
                                        Console.Write(FirstChar);
                                    }
                                }


           Console.ReadLine();


        }

    }
}
