using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Lines
    {
        static void Main(string[] args)
        {


            List<string> list=new List<string>();

          //  int[,] screen = new int[8, 8];
          // int output = Convert.ToInt32(list[1], 2);

            for (int i = 0; i < 8; i++) {

                list.Add(Convert.ToString(int.Parse(Console.ReadLine()),2).PadLeft(8,'0'));
            }


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            int maxLine = 0;
            int maxRepeating=0;

            for (int i = 0; i < 8; i++)
            {
                if (getMaxLineInBinary(Convert.ToInt32(list[i], 2)) > maxLine) {
                    
                    
                    
                    maxLine = getMaxLineInBinary(Convert.ToInt32(list[i], 2)); 
                
                
                }
              //Console.WriteLine(maxLine);
            }


            for (int i = 0; i < list.Count; i++)
            {


                if (getMaxLineInBinary(getVerticalNumber(list, i)) > maxLine) { maxLine = getMaxLineInBinary(getVerticalNumber(list, i)); }


            }


            




           Console.WriteLine(maxLine);
           // Console.WriteLine(getMaxLineInBinary( Convert.ToInt32(list[0], 2)));
            Console.ReadLine();
        }

        public static int getVerticalNumber(List<string> matrix,int column) {

            int result = 0;
            string bin = "";

            for (int i = 0; i < 8; i++)
            {

               bin += matrix[i][column];
            }

            result = Convert.ToInt32(bin, 2);

            return result;
        }


        public static int getMaxLineInBinary(int bin) {

            int result = 0;
            int MaxLine = 0;
            int maxLineCurent=0;
        //    int k = 0;
            while (bin > 0) {

          //      k++;
         //     Console.WriteLine(  Convert.ToString(bin, 2).PadLeft(8, '0'));

                if ((bin & 1) == 1) { maxLineCurent ++; } else if((bin & 1) == 0 ) {

                    if(maxLineCurent>=MaxLine){
                        MaxLine = maxLineCurent;
                        maxLineCurent = 0;
                    }

                }
              //  Console.WriteLine(k+"--"+maxLineCurent);
                bin=bin>>1;
            }

            if (maxLineCurent > MaxLine) { MaxLine = maxLineCurent; }

            return MaxLine;

        }


    }
}
