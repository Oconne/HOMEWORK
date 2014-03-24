using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore2
{
    class BonusScore2
    {
        static void Main(string[] args)
        {

            int bonusScore = int.Parse(Console.ReadLine());

            bool range13 = bonusScore >= 1 && bonusScore <= 3;
            bool range46 = bonusScore >= 4 && bonusScore <= 6;
            bool range79 = bonusScore >= 7 && bonusScore <= 9;
            bool outOFrange = bonusScore <=0 || bonusScore> 9;

             Console.Write(range13?( bonusScore*10).ToString():"") ;
             Console.Write(range46 ? (bonusScore * 100).ToString() : "");
             Console.Write(range79 ? (bonusScore * 1000).ToString() : "");
             Console.Write(outOFrange ? "Invalid Score" : "");

            Console.ReadLine();

        }
    }
}
