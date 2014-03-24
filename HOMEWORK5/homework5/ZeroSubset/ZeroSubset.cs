using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
           
             int[] numbers={1,1,-1,-2,3};

           for (int k=0 ;k<5;k++) {numbers[k] = int.Parse(Console.ReadLine()); }

	         int number=0;
	         Array.Sort(numbers);
	         KNumberSubset ki=new KNumberSubset(numbers,number);
	         ki.findSubset(0);
             Console.ReadLine();
 

        }

        public class KNumberSubset
        {
            private int number;
            private int sum;
            private LinkedList<int> subset;
            private int[] numbers = { 6, 2, 2, 4, 2 };
  
            public KNumberSubset(int[] numbers, int number)
            {
               
                this.numbers = numbers;
                this.number = number;
                sum = 0;
                subset = new LinkedList<int>();
            }
            public void findSubset(int startPoint)
            {
                string output = "";
                int check = 0;
              
             //  -------
                    for (int i = startPoint; i < 5; i++)
                    {
                        sum = sum + numbers[i];
                        if (sum > number)
                        {
                            sum = sum - numbers[i];
                            if ( check == 0) { Console.WriteLine("no zero subset"); }
                            break;
                        }
                        subset.AddLast((int)numbers[i]);
                  
                        findSubset(i + 1);
                        sum = sum - numbers[i];
                        subset.RemoveLast();
                       
                    }

                if (sum == number)
                {
                   
                    foreach (int k in subset) { output += k + "+"; }
                    if (output.Length > 0)
                    {
                       check++;  Console.WriteLine(output.Substring(0,output.Length-1) + " = " + sum);
                    }
                    
                }

               


            }


        }

    }
}
