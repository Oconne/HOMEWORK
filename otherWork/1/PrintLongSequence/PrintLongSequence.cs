using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <=1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                Console.Write(",");
            }
            else
            {
                Console.Write(i * -1);
                Console.Write(",");
            }
        }
      //  Console.Write(-1001);
        Console.ReadLine();
    }
}
    

