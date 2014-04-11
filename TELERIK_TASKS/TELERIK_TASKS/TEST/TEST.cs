using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class TEST
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)'Z');
           // Console.WriteLine( 5.657-5.657 % 1);
           // Console.WriteLine((decimal)41412.8 % 1);
            //Console.WriteLine("@");



            uint N = uint.Parse(Console.ReadLine());
           
          //  string bin=Convert.ToString(N, 2).PadLeft(8, '0');

 //          int width = int.Parse(Console.ReadLine());
          int row = int.Parse(Console.ReadLine());


          //   int  p = -7;
          //   p = (~p)+1; //(~0)>>10;

//            uint widthMask = (~(uint)0>>(32-width));

            uint rowMask = (~(uint)0 >> (32 - row)); // left
            uint rowMaskL = (~(uint)0 >> (32 - row))<<row;

            uint PfromN = N & rowMask;
            uint PfromN2 = N & rowMaskL;
            ;
         uint   N1 =  N&(~PfromN)|  leftDistribution( PfromN);//<---------- rowMask
         uint N2 = N & (~rowMaskL) | rightDistribution(PfromN2);
          
            // int lenghtMask =1;
            //for (int i = 0; i < width-1; i++) { lenghtMask=(lenghtMask<<1)+1;}

            Console.WriteLine(Convert.ToString(N, 2).PadLeft(8, '0'));
            Console.WriteLine(Convert.ToString(N2, 2).PadLeft(8, '0'));
            Console.WriteLine(Convert.ToString(N1, 2).PadLeft(8, '0'));

                Console.WriteLine( Convert.ToString( rightDistribution( PfromN2  ) , 2));
                //   Console.WriteLine( Convert.ToString(  leftDistribution( PfromN )  , 2));
                //  Console.WriteLine( Convert.ToString(  PfromN   , 2));

                   Console.WriteLine(PfromN);
 
          


            Console.WriteLine();
            Console.ReadLine();

        }


        public static uint leftDistribution(uint N_) {

            uint p=N_;
            uint result=0;
//v1
            string bin = Convert.ToString(N_, 2).Replace("0","").PadLeft(getLenghtOfBinary(N_),'0');
            result =(uint)Convert.ToInt32(bin, 2);


            return result;
        }

        public static uint rightDistribution(uint N_)
        {

            uint p = N_;
            uint result = 0;
            //v1
            string bin = Convert.ToString(N_, 2).Replace("0", "").PadRight(getLenghtOfBinary(N_), '0');
            result = (uint)Convert.ToInt32(bin, 2);


            return result;
        }



        public static int getLenghtOfBinary(uint N){
            int result = 0;
            while (N > 0) { N >>= 1; result++; }

          return result;

        }


    }
}
