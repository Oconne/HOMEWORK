using System;

    class PrintSequence
    {
        static void Main()
        {
            int a = 2;
            int b = -3;

            Console.Write(a + ",");
            Console.Write(b + ",");

            for (int i = 0; i < 4; i++) 
            {
                Console.Write((a += 2) + ",");
                Console.Write((b -= 2) + ",");
            }

            Console.ReadLine();
        }
    }

