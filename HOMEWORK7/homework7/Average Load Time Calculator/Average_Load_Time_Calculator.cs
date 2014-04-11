using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Load_Time_Calculator
{
    class Average_Load_Time_Calculator
    {
        static void Main(string[] args)
        {

    string log=    
@"2014-Mar-02 11:33 http://softuni.bg 8.37725 
2014-Mar-02 11:34 http://www.google.com 1.335 
2014-Mar-03 21:03 http://softuni.bg 7.25
2014-Mar-03 22:00 http://www.google.com 2.44
2014-Mar-03 22:01 http://www.google.com 2.45 
2014-Mar-03 22:01 http://www.google.com 2.77";
//   0        1             2             3

/*
     string log =

    @"2014-Apr-01 02:01 http://softuni.bg 8.37725
2014-Apr-01 02:05 http://www.nakov.com 11.622
2014-Apr-01 02:06 http://softuni.bg 4.33
2014-Apr-01 02:11 http://www.google.com 1.94
2014-Apr-01 02:11 http://www.google.com 2.011
2014-Apr-01 02:12 http://www.google.com 4.882
2014-Apr-01 02:34 http://softuni.bg 4.885
2014-Apr-01 02:36 http://www.nakov.com 10.74
2014-Apr-01 02:36 http://www.nakov.com 11.75
2014-Apr-01 02:38 http://softuni.bg 3.886
2014-Apr-01 02:44 http://www.google.com 1.04
2014-Apr-01 02:48 http://www.google.com 1.4555
2014-Apr-01 02:55 http://www.google.com 1.977";


*/
            
   
     List<string> list = log.Split('\n').ToList<string>();

     Dictionary<string, List<string>> data=  new Dictionary<string, List<string>>();

     foreach (string s in list)
     {
         List<string> row = s.Split(' ').ToList<string>();
         List<string> dataRow = new List<string>();
          dataRow.Add(row[2]); dataRow.Add(row[3]);


         data[row[0]+" "+row[1]] = dataRow;

     }

     List<string> getAllWeb = new List<string>();



     foreach (var item in data)
     {
         getAllWeb.Add(item.Value[0]);
     }

     getAllWeb = getAllWeb.Distinct().ToList();

     double sum = 0; int count = 0;
     foreach (string s in getAllWeb) {

         foreach (var item in data)
         {
             if (item.Value[0] == s) {

                 sum += double.Parse( item.Value[1]);
                 count++;
             }
         }
         Console.WriteLine("{0} -> {1}", s, sum / count); sum = 0; count = 0;

           }

         

     
     


            //testing
            //Console.WriteLine(data["2014-Mar-03 22:01"][0]);
            //Console.WriteLine(list[4]);



            Console.ReadLine();



        }
    }
}
