using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Na_Baba_mi_Smetalnika
{
    class Program
    {
        static void Main(string[] args)
        {


             uint[] N = new uint[8];

                int width = int.Parse(Console.ReadLine());
                int row,column,rightColumn ;
             string instructions = "begin";


                            for (int i = 0; i < 8; i++) //------------
                            {

                                N[i] = uint.Parse(Console.ReadLine());
                            }
          

                    while (true) {

                        instructions = Console.ReadLine();
                        
                        if (instructions == "stop"){break; }

                        if (instructions == "reset")
                        {

                            for (int i = 0; i < 8; i++)
                            {
                                uint rowMaskR = (~(uint)0 >> (32 - (width))) << (0);
                                uint PfromN2 = N[i] & rowMaskR;
                                N[i] = (N[i] & (~rowMaskR)) | rightDistribution(PfromN2, width);


                            }

                            continue;
                        }



                        row = int.Parse(Console.ReadLine());
                      
                        rightColumn = int.Parse(Console.ReadLine());
                         if (rightColumn >= width) { row = 0; } else if (rightColumn < 0) { row = width - 1; }
                        column = width-(rightColumn);

                        if(instructions=="left")
                        {

                            uint rowMaskL = (~(uint)0 >> (32 - column)); // left
                            uint PfromN = N[row] & rowMaskL;
                            N[row] =( N[row] & (~rowMaskL)) | leftDistribution(PfromN,width);//<---------- rowMask
                           

                        
                        }
                        else  if(instructions=="right")
                        {

                           uint rowMaskR = (~(uint)0 >> (32 - (rightColumn+1))) << (width-rightColumn-1);
                           uint PfromN2 = N [row]& rowMaskR;
                           N[row] = (N[row] & (~rowMaskR)) | rightDistribution(PfromN2,width);


                        }

                        

            
                    }

                    int zerocount = 0;
                    int check = 0;

                    for (int k = 0;k< width ; k++)
                    {

                        check = 0;

                        for (int i = 0; i <8; i++)
                        {
                            if (((N[i] >> k) & 1) == 1) { check++;  }
                            
                            
                        }

                        if (check == 0)
                        {
                            zerocount++;
                        }

                    }




                   uint sum = 0;

                    foreach (var item in N)
                    {

                        sum += item;
                        Console.WriteLine(Convert.ToString(item,2).PadLeft(width,'0'));
                    }



                  //  Console.WriteLine(zerocount);
                    Console.WriteLine(sum*zerocount);
            Console.ReadLine();

        }
        public static uint leftDistribution(uint N_,int width_)
        {

            uint p = N_;
            uint result = 0;
            //v1
            string bin = Convert.ToString(N_, 2).Replace("0", "").PadLeft(width_, '0');
            result = (uint)Convert.ToInt32(bin, 2);


            return result;
        }

        public static uint rightDistribution(uint N_,int width_)
        {

            uint p = N_;
            uint result = 0;
            //v1
            string bin = Convert.ToString(N_, 2).Replace("0", "").PadRight(width_, '0');
            result = (uint)Convert.ToInt32(bin, 2);


            return result;
        }



        public static int getLenghtOfBinary(uint N)
        {
            int result = 0;
            while (N > 0) { N >>= 1; result++; }

            return result;

        }



    }
}
