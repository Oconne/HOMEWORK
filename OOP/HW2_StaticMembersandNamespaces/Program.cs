using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_StaticMembersandNamespaces
{

    class Program
    {
        static void Main(string[] args)
        {
/*

            Console.WriteLine("Problem 1.	Point3D\n__________________________________\n\n");

            Console.WriteLine("Starting poin: "+Point3D.StartingPoint.ToString());

            Point3D p1 = new Point3D();
            Console.WriteLine(p1.ToString());
            Point3D p2 = new Point3D(3, 67, 19999);
            p2.X = 200.555;
            Console.WriteLine(p2.ToString());

            Console.WriteLine("Problem 2.	Distance Calculator\n__________________________________\n\n");
            Console.WriteLine("The distanse between \n" + p1.ToString() + "and\n" + p2.ToString() + "is " + DistanseCalculator.CalculateDistance(p1, p2));
*/

/*
            Console.WriteLine("Problem 3.	 Paths\n__________________________________\n\n");



             Point3D p4 = new Point3D(19, 299, 993);
             Point3D p5 = new Point3D(4, 5, 6);
             Point3D p6 = new Point3D(7, 8, 9);

             List<Point3D> path1List = new List<Point3D> { p4, p5, p6 };


             Path3D path1 = new Path3D(path1List);
             path1.addPointToPath(new Point3D(3, 5, 6));

             Console.WriteLine("TOFILE: "+path1.ToString());

             Storage.SavePathToFile(@"path1.txt", path1); // the file is in bin directory

             Path3D pathEmpty = new Path3D();

            

             Storage.LoadPathFromFile(@"path1.txt",ref pathEmpty);

             pathEmpty.addPointToPath(new Point3D(7, 7, 7));

             Console.WriteLine("FROMFILE"+pathEmpty.ToString());

*/



/*
             Console.WriteLine("Problem 4.	 HTML Dispatcher\n__________________________________\n\n");


             HTMLDispatcher htmlElementDiv = new HTMLDispatcher();
             Console.WriteLine(htmlElementDiv.HTMLElement);
             
             htmlElementDiv.addAtribute("href=\"www.softuni.bg\"");
             Console.WriteLine(htmlElementDiv.HTMLElement);
             HTMLDispatcher innerHTMLP = new HTMLDispatcher("p");
             innerHTMLP.InnerElement = "Hello";
             Console.WriteLine(innerHTMLP.HTMLElement);

             htmlElementDiv.addAtribute("class=\"links\"" );
             htmlElementDiv.InnerElement = innerHTMLP.HTMLElement;
             Console.WriteLine(htmlElementDiv*2);

             Console.WriteLine( HTMLBuilder.CreateImage("www.softuni.bg","Smile","Penka"));
        
*/

            BitArray bit = new BitArray();
            Console.WriteLine(bit[0].ToString());
            bit[7] = 1;
           Console.WriteLine(bit.ToString());



        }

    }



}
