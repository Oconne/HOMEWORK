// Write a program that prints an isosceles triangle of 9 copyright symbols ©

namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    class Triangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            char copyright = '\u00A9';
            string triangle = string.Format(
                                "   {0}\n" +
                                "  {0} {0}\n" +
                                " {0}   {0}\n" + 
                                "{0} {0} {0} {0}\n", copyright);

            Console.WriteLine(triangle);
        }
    }
}
