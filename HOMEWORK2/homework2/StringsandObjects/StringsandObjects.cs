using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsandObjects
{
    class StringsandObjects
    {
        static void Main(string[] args)

        {

            string str1 = "Hello";
            string str2 = "World";
          //  object ob = str1 +" "+ str2+" !" ;
            object ob = str1 + str2;
            string str3 = (string)ob;
            Console.WriteLine(ob);
           Console.WriteLine(str3);
           Console.ReadLine();
        }
    }
}
