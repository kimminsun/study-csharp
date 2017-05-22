using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{
    class Program
    {
        static void Main( string[] args )
        {
            CPoint4i tmpP = new CPoint4i();
            tmpP.theX = 3;
            Console.WriteLine( "X:{0}", tmpP.theX );
            Console.WriteLine( "[0]:{0}", tmpP[ 0 ] );

            tmpP[ 1 ] = 8;
            Console.WriteLine( "Y:{0}", tmpP.theY );
            Console.WriteLine( "[1]:{0}", tmpP[ 1 ] );

            tmpP[ "Z" ] = 36;
            Console.WriteLine( "Z:{0}", tmpP.theZ );
            Console.WriteLine( "[2]:{0}", tmpP[ 2 ] );
            Console.WriteLine( "\"Z\":{0}", tmpP["Z"] );

            Console.WriteLine();
            string[] tmpStrs = { "X", "Y", "Z", "W" };
            foreach(string iter in tmpStrs)
            {
                Console.WriteLine( "{0}:{1}", iter, tmpP[ iter ] );
            }

            Console.ReadKey();
        }
    }
}
