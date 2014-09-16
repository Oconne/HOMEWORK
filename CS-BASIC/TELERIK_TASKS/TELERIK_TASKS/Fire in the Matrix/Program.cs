using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_in_the_Matrix
{
    class Program
    {

        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            List<string> simetry=new List<string>();

            for (int i = 1; i < width/2+1; i++)
            {
               
                string a0=new string('.',width/2-i);
                string a1="#";
                string a2 = new string('.', (i-1)*2);

                simetry.Add(string.Format("{0}{1}{2}{1}{0}", a0, a1, a2));
                Console.WriteLine("{0}{1}{2}{1}{0}", a0, a1, a2);
                 
            }

            for (int i = simetry.Count-1; i > width/4-1; i--)
            {
                Console.WriteLine(simetry[i]);
            }


            Console.WriteLine(new string('-',width));

            for (int i = 0; i < width / 2 ; i++)
            {

                string a0 = new string('.',  i);
                string a1 = new string('\\', width / 2 - i);
                string a2 = new string('/', width / 2 - i);

                Console.WriteLine("{0}{1}{2}{0}", a0, a1,a2);
                //if (width / 2 - i == 0) { break; }
            }



            Console.ReadLine();
        }
    }
}
