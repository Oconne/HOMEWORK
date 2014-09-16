using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace FallingRocks2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 60;
            Random randomGenerator = new Random();
            int t = 0; int t1 = 0; int t2 = 0;
            string rock = "$"; string rock1 = "#";
            string antyrock = " ";
            bool k = false;
            bool k2 = false;
           // Rocks rock = new Rocks("#",5);
            int   x = randomGenerator.Next(0, 60);
            string screen = "";
            int p = 0;
         for (int i = 0; i < 60 ; i++) { screen =" "+screen; }

            while (true)
            {  
            t++;
                     Console.SetCursorPosition(0,0);
                     Console.Write(screen);
                    //Console.ForegroundColor = ConsoleColor.Magenta;
                    //Console.SetCursorPosition(0, t );//t-1
                    //Console.WriteLine("{0,"+x+"}",antyrock);
                    //if (t == 15) { t = 0; x = randomGenerator.Next(0, 60); drowRock(ref rock, randomGenerator.Next(0, 4),ref antyrock); continue; }
                    //Console.SetCursorPosition(0, t+1); //t
                    //Console.WriteLine("{0,"+x+"}",rock);
                    p = randomGenerator.Next(0,9);
                     if (p<3 ){         screen = "                                             $$$$$$         " + screen;}
                    
                     else if (p > 3) {  screen = "                                                            " + screen; }


                    if (t > 20) { screen = screen.Substring(0, 19 * 60); }

                Thread.Sleep(150);
               
            }

        }



        public static string drowRock(string sign){
            int i=0;
            string result = "";
            Random r = new Random();
            while (i < 60) { i++; result = result + sign; }

            return result;
        }

      public  class Rocks
        {
            public int x=0;
            public int y=0;
            public string sign="";
            public int size=0;
            public string body="";
            public ConsoleColor color=ConsoleColor.Magenta;
            public double density=1;
          

            public  Rocks(string sign_,int size_) {

                size = size_;
                sign = sign_;
                
                for (int i = 0; i < size; i++) { body += sign; } }

        }
    }
}
