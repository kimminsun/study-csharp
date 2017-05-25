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

            List<int> tmpList = new List<int>();

            tmpList.Add( 35 );
            tmpList.Add( 27 );
            tmpList.Add( 10 );

            Console.WriteLine( tmpList[ 0 ] );
            Console.WriteLine( tmpList[ 1 ] );

            foreach(int iter in tmpList)
            {
                Console.WriteLine( iter );
            }
            tmpList.Sort();
            foreach(int iter in tmpList)
            {
                Console.WriteLine( iter );
            }

            List<string> strList = new List<string>();
            strList.Add( "VIPS" );
            strList.Add( "Vshley" );
            strList.Add( "Outback" );

            strList.Sort();
            foreach(string iter in strList)
            {
                Console.WriteLine( iter );
            }
            if(strList.Contains("VIPS")==true)
            {
                Console.WriteLine( "Find!" );
            }

            List<List<string>> itemList = new List<List<string>>();
            List<string> itemAttack = new List<string>();
            itemAttack.Add( "Sword" );
            itemAttack.Add( "Axe" );
            itemAttack.Add( "Spear" );
            itemList.Add( itemAttack );

            List<string> itemDefend = new List<string>();
            itemDefend.Add( "Shield" );
            itemDefend.Add( "Armor" );
            itemList.Add( itemDefend );

            List<string> itemPortion = new List<string>();
            itemPortion.Add( "Healing" );
            itemPortion.Add( "Flying" );
            itemPortion.Add( "Fog" );
            itemPortion.Add( "Fast" );
            itemList.Add( itemPortion );

            foreach(List<string>iterList in itemList)
            {
                foreach(string iterStr in iterList)
                {
                    Console.Write( iterStr );
                    Console.Write( " " );

                }
                Console.WriteLine();
            }
            Console.WriteLine( itemList[ 0 ][ 1 ] );
            Console.WriteLine( itemList[ 1 ][ 0 ] );
            Console.WriteLine( itemList[ 2 ][ 2 ] );

            Console.ReadKey();
        }
    }
}
