using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrentDate
{
    class CurrentDate
    {
        static void Main(string[] args)
        {
            Console.Write(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.ReadLine();
        }
    }
}
