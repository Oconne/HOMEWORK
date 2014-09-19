using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HW2_StaticMembersandNamespaces
{


    class BitArray
    {


        private int[] bits;


        public BitArray() { 
        
        bits=new int[100000];
        
        }




        public int this[int index]    // Indexer declaration
        {

            get { return bits[index]; }
            set {

                if (index < 0 && index > 1) {

                    throw new Exception("Bit has values 0 or 1");
                }

               bits[ index] = value;
            
            }

        }

        public override string ToString()
        {

       
            //BigInteger big=0;

            //for (int i = 0; i < 100000; i++) { 
            
            //big+=(int)Math.Pow(2 ,this[i]);

            //}


            BigInteger num = BigInteger.Zero;
            BigInteger exp2 = BigInteger.One;
            for (int pos = 0; pos < 100000; pos++)
            {
                exp2 *= 2;
                if (this[pos]==1)
                {
                    num += exp2 / 2;
                }
            }




            return ""+num;
        }




    }


}
