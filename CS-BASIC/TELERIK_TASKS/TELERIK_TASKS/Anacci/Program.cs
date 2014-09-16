using System;
// 70/100
class Anacci
{
    static void Main()
    {
        char firstLetterChar = char.Parse(Console.ReadLine());
        char secondLetterChar = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        char whiteSpace = ' ';

        int firstLetterCode = ParseCharToInt(firstLetterChar);
        int secondLetterCode = ParseCharToInt(secondLetterChar);

        int nextLetterCode = ParseCharToInt(firstLetterChar);

        for (int i = 0; i < lines * 2 - 1; i++)
        {
            nextLetterCode = firstLetterCode;
            firstLetterCode = secondLetterCode;
            secondLetterCode = nextLetterCode + secondLetterCode;

            if (nextLetterCode <= 26 ) //&& nextLetterCode>0
            {
                //Console.WriteLine(nextLetterCode + "<----------");
                if (i % 2 == 0 && i > 1)
                {
                    Console.Write(new string(whiteSpace, i / 2 - 1));
                }
                else
                {
                    Console.WriteLine();
                }
                Console.Write(ParseIntToChar(nextLetterCode));
            }
            else if (nextLetterCode > 26)
            {
                nextLetterCode %= 26;
                if (i % 2 == 0 && i > 1)
                {
                    Console.Write(new string(whiteSpace, i / 2 - 1));
                }
                else
                {
                    Console.WriteLine();
                }
                Console.Write(ParseIntToChar(nextLetterCode));
            }

            

        }Console.ReadLine();
    }

    private static char ParseIntToChar(int letterCode)
    {
        char c = (char)(letterCode + 64);
      // if (letterCode + 64 < 65) { c = 'A'; }

        return c;
    }

    private static int ParseCharToInt(char c)
    {
       
        int letterCode = c - 64;
      //  if (letterCode < 65) { letterCode = 65; }

        return letterCode;
    }
}