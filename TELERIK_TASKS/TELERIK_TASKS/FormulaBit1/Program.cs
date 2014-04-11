using System;
using System.Collections.Generic;
using System.Text;

namespace BITLANDIA
{
    class Program
    {

        public static void Main(string[] args)
        {

            Convertor con = new Convertor();
            List<string> FormulaField = new List<string>();



            for (int i = 0; i < 8; i++) { FormulaField.Add(con.DecimalToBinary()); }

            foreach (string s in FormulaField) { Console.WriteLine(s); }

            int X = 7;
            int Y = 0;
            int dx = 0;
            int dy = 1;
            string turns = "0s";
            int n = 0;
            int p1 = 0;
            int p2 = 0;
            int length = 0;
            int luck = 0;


            //Console.WriteLine("-------------------");

            do
            {
                n++;


                if (FormulaField[0].Substring(7, 1) == "1") { luck = -1; break; }

                if (X == 0 && Y == 7) { luck = 1; break; }

                //Console.WriteLine(p1+"__"+p2);


                if (X + dx < 0 || Y + dy < 0 || X + dx > 7 || Y + dy > 7)
                {
                    p1++; con.ChangeDirection(ref dx, ref dy, ref turns);
                    if (p1 == 2) { turns = turns.Substring(0, turns.Length - 2); luck = -1; break; } continue;
                }
                if (FormulaField[Y + dy].Substring(X + dx, 1) == "1")
                {
                    p2++; con.ChangeDirection(ref dx, ref dy, ref turns);

                    if (p2 == 2) { turns = turns.Substring(0, turns.Length - 2); luck = -1; break; } continue;
                }



                Y += dy; X += dx;
                p1 = 0;
                p2 = 0;
                length++;

                StringBuilder sb = new StringBuilder(FormulaField[Y]);
                sb[X] = '*';
                FormulaField[Y] = sb.ToString();



                //Console.WriteLine(FormulaField[Y]);//sb.ToString()


            } while (n <= 64); //!(X==-1 && Y==-1) tuk sys brake !(X==7 && Y==7)


            //foreach(string s in FormulaField){Console.WriteLine(s);}

            turns = turns.Substring(2, turns.Length - 2);
            //Console.WriteLine(turns);//.Substring(2,turns.Length-2)
            if (luck == 1)
            {
                Console.WriteLine((length + 1) + " " + turns.Length);
            }
            else
            {
                Console.WriteLine("No " + (length + 1));
            }
        }


    }
    public class Convertor
    {

        public string DecimalToBinary()
        {

            //Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            //  if(decimalNumber<1){return string.Empty;}


            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            // if(result==string.Empty){result="0";Console.WriteLine("xxx");}

            return result.PadLeft(8, '0');
        }

        public void ChangeDirection(ref int dx_, ref int dy_, ref string turns_)
        {



            if (turns_.Substring(turns_.Length - 1, 1) == "s") { dx_ = -1; dy_ = 0; turns_ += "w"; }
            else if (turns_.Substring(turns_.Length - 1, 1) == "w" && turns_.Substring(turns_.Length - 2, 1) == "s") { dx_ = 0; dy_ = -1; turns_ += "n"; }
            else if (turns_.Substring(turns_.Length - 1, 1) == "n") { dx_ = -1; dy_ = 0; turns_ += "w"; }
            else if (turns_.Substring(turns_.Length - 1, 1) == "w" && turns_.Substring(turns_.Length - 2, 1) == "n") { dx_ = 0; dy_ = 1; turns_ += "s"; }//n



        }

    }


}




//Console.WriteLine("Press ESC to stop");
//do {
//  while (! Console.KeyAvailable) {
// Do something
// }       
//} while (Console.ReadKey(true).Key != ConsoleKey.Escape);