using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {

        static void Main(string[] args)
        {
           
            int tomato =int.Parse(Console.ReadLine()), tomatoA =int.Parse(Console.ReadLine()),
                cucumber =int.Parse(Console.ReadLine()), cucumberA =int.Parse(Console.ReadLine()),
                potato =int.Parse(Console.ReadLine()), potatoA =int.Parse(Console.ReadLine()),
                carrot =int.Parse(Console.ReadLine()), carrotA =int.Parse(Console.ReadLine()),
                cabbage= int.Parse(Console.ReadLine()), cabbageA= int.Parse(Console.ReadLine()),
                beans=int.Parse(Console.ReadLine()),beansA;
           
         double tomatoP=0.5,cucumberP=0.4,potatoP=0.25,carrotP=0.6,cabbageP=0.3,beansP=0.4,Cost;

            int S = 250;
            int VegatableArea = tomatoA+ cucumberA+potatoA+carrotA+cabbageA;
                beansA = S - VegatableArea;
                Cost = tomato * tomatoP + cucumber * cucumberP + potato * potatoP + carrot * carrotP + cabbage * cabbageP + beans * beansP;

         string areaCheck;

                         if (VegatableArea > S)
                         {
                             areaCheck = "Insufficient area";
                             Console.Write("Total costs: {0:f2}\n{1}", Cost, areaCheck);
                         }
                         else if (VegatableArea == S)
                         {
                             areaCheck = "No area for beans";
                             Console.Write("Total costs: {0:f2}\n{1}", Cost, areaCheck);
                         }
                         else
                         {
                             areaCheck = beansA.ToString();
                             Console.Write("Total costs: {0:f2}\nBeans area: {1}", Cost, areaCheck);
                         }


               
                Console.ReadLine();



}
    }
}
