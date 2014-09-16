using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<int> KardSequence=new  List<int>();
//V1
            for (int i = 0; i < 5; i++)
            {
               int k=char.Parse(Console.ReadLine().Substring(0,1));
                if (k >= 50 && k <= 60)
                {
                    KardSequence.Add(k-48);
                }
                else if (k == 49) { KardSequence.Add(10); }
                else if (k == 74) { KardSequence.Add(11); }
                else if (k == 81) { KardSequence.Add(12); }
                else if (k == 75) { KardSequence.Add(13); }
                else if (k == 65) { KardSequence.Add(14); }

            }


            List<int> distinkt = KardSequence.Distinct().ToList();
            List<int> pokerSequenceCount = new List<int>();

            for (int i = 0; i < distinkt.Count; i++)
            {
                pokerSequenceCount.Add(0);
                foreach (int s in KardSequence)
                {
                    if (distinkt[i] == s) { pokerSequenceCount[i]++; }

                }

            }

        
            pokerSequenceCount.Sort();

            switch (pokerSequenceCount.Count) {

                case 5:   l:
                    if (KardSequence[4] - KardSequence[0] == 4) { Console.WriteLine("Straight"); }
                    else if (KardSequence[4] == 14) { KardSequence.Insert(0, 1); KardSequence.RemoveAt(KardSequence.Count-1);goto l; }
                    else { Console.WriteLine("Nothing"); }
                    
                    ; break;

                case 4: Console.WriteLine("One Pair"); break;
                    
                case 3:
                    if (pokerSequenceCount[1] == 1) { Console.WriteLine("Three of a Kind"); }
                    else { Console.WriteLine("Two Pairs"); }
                    ; break;

                case 2:

                    if (pokerSequenceCount[0] == 1) { Console.WriteLine("Four of a Kind"); }
                    else { Console.WriteLine("Full House"); }

                    ; break;

                 case 1: Console.WriteLine("Impossible");  break;
            
            }


            Console.ReadLine();
        }

      
    }
}
