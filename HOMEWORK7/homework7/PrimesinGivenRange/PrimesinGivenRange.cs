using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesinGivenRange
{
    class PrimesinGivenRange
    {
        static void Main(string[] args)

        {
            printList(FindPrimesInRange(int.Parse(Console.ReadLine()) ,int.Parse(Console.ReadLine()) ));

            Console.ReadLine();



        }



    public static bool IsPrime(  int prime) {

          
            bool isprime = true;
            if (prime < 2) { isprime = false; } 
            else { for (int i = 2; i < prime; i++) 
            { if (prime % i == 0) { isprime = false; break; } } }

            return isprime;

        } 
    
     public   static List<int> FindPrimesInRange(int startNum,int endNum){
     
     List<int> primeInRange=new List<int>();

     for(int i=startNum;i<=endNum;i++)
     {
        if (IsPrime(i) == true) 
         {
             primeInRange.Add(i);
         }
     }

     return primeInRange;
     
     }


     public static void printList( List<int> list) {

         foreach (int s in list) { Console.Write(s+", "); }
         Console.SetCursorPosition(Console.CursorLeft-2, Console.CursorTop);
         Console.Write(" ");
     
     }

    
    } 
    
   
}
