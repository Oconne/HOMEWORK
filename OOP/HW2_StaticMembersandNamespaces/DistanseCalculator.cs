using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_StaticMembersandNamespaces
{
    class DistanseCalculator
    {


      //  static DistanseCalculator() { }

        public static double CalculateDistance (Point3D firstPoint, Point3D secondPoint){

         double result  = Math.Sqrt(Math.Pow(firstPoint.X-secondPoint.X,2)+
            Math.Pow(firstPoint.Y-secondPoint.Y,2)+
            Math.Pow(firstPoint.Z-secondPoint.Z,2));

                return result;
        
        }


    }
}
