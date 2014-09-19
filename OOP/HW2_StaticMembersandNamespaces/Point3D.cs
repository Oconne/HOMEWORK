using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_StaticMembersandNamespaces
{
    class Point3D
    {
        private static readonly Point3D starting_point_=new Point3D();

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static  Point3D StartingPoint {

            get { return Point3D.starting_point_; }
    
    
        }


        public Point3D(string[] dataPoint) {
        
          this.X = double.Parse(dataPoint[0]);
          this.Y = double.Parse(dataPoint[1]);
          this.Z = double.Parse(dataPoint[2]);
        
        }
        
        public Point3D():this(0,0,0){}

         public Point3D(double x,double y, double z)
         {

          this.X = x;
          this.Y = y;
          this.Z = z;

             
         }


      //   public Point3D(Point3D point3D) { }
         
         
         
         


         public override string ToString()
         {
             return String.Format("3D-Point [{0}, {1}, {2}]\n\nX coordinate: {0}\nY coordinate: {1}\nZ coordinate: {2}\n", this.X,this.Y,this.Z);
         }


         public string toDataPoint() {


             return String.Format("({0},{1},{2})", this.X, this.Y, this.Z);
         
         }


    }
}
