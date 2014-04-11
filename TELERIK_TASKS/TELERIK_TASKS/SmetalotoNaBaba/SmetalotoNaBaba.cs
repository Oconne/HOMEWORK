using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmetalotoNaBaba
{
    class SmetalotoNaBaba
    {

        static void Main(string[] args)
        {

            

            int width=int.Parse(Console.ReadLine());



            int[,] smetaloMatrix = new int[8, width];


            for (int i = 0; i < 8; i++)
            {
                int N = 0;

                int.TryParse(Console.ReadLine(), out N);

                for (int k = 0; k < width; k++)
                {

                    smetaloMatrix[i, width - k - 1] = (N >> k) & 1;

                }

            }

            for (int i = 2; i < 8; i++)
            {
                matrixTransform(smetaloMatrix,i, 0, "right");

            }


            int p = 0;

            foreach (var item in smetaloMatrix)
            {
                p++;
                Console.Write(item); if (p == width) { Console.WriteLine(); p = 0; }
            }









            Console.ReadLine();



        }


        public static int[,] matrixTransform(int[,] matrix, int row, int column, string model) {



            switch(model){
                case "right":
            for (int i = matrix.GetLength(0)-1; i >=column; i--)
            {
                if(matrix[row,i]==0){

                    for (int k = i - 1; k >= column; k--) { if (matrix[row, k] == 1) { matrix[row, i] = 1; matrix[row, k] = 0; break; } }
                
                }
                
             }

            break;
                         
                case "left":

            for (int i =0 ; i <= column; i++)
            {
                if (matrix[row, i] == 0)
                {

                    for (int k =i+ 1; k <= column; k++) { if (matrix[row, k] == 1) { matrix[row, i] = 1; matrix[row, k] = 0; break; } }

                }

            }







            break;

        }

                return matrix;
        
        }


    }
}
