using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_03
{
    class Program
    {
        static void CopyArray<T>(T[]aSource,out T[] aTarget)
        {
            if(aSource.Length==0)
            {
                aTarget = null;
                return;
            }
            aTarget = new T[ aSource.Length ];
            //int i;
            //for(i=0;i<aSource.Length;i++)
            //{
            //    aTarget[ i ] = aSource[ i ];
            //}

            int i = 0;
            foreach(T iter in aSource)
            {
                aTarget[ i ] = iter;
                i++;
            }
            return;
        }

        static void Main( string[] args )
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            int[] intRes;
            CopyArray<int>( intArr, out intRes );
            foreach(int iter in intRes)
            {
                Console.WriteLine( "{0}", iter );
            }

            string[] strArr = { "A", "B", "C", "D", "E" };
            string[] strRes;
            CopyArray<string>(strArr,out strRes);
            foreach(string iter in strRes)
            {
                Console.WriteLine( "{0}", iter );
            }

            CPoint2i[] pxArr = { new CPoint2i( 1, 2 ), new CPoint2i( 3, 4 ), new CPoint2i( 5, 6 ) };
            CPoint2i[] pxRes;
            CopyArray<CPoint2i>( pxArr, out pxRes );
            foreach(CPoint2i iter in pxRes)
            {
                Console.WriteLine( "({0},{1})", iter.theX, iter.theY );
            }

            Console.ReadKey();
        }
    }
}
