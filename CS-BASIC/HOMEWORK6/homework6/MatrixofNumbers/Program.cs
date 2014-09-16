using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++) {

                for (int k = i; k <=i+ N-1; k++) {
                    
                      Console.Write(k + " "); 
                    ; }

                Console.WriteLine();
                  ; }
            Console.ReadLine();

        }
    }
}
