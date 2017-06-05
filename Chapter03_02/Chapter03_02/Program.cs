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
            Console.WriteLine( "\"Z\":{0}", tmpP[ "Z" ] );

            Console.WriteLine();
            string[] tmpStrs = { "X", "Y", "Z", "W" };
            foreach ( string iter in tmpStrs )
            {
                Console.WriteLine( "{0}:{1}", iter, tmpP[ iter ] );
            }
            List<int> tmpList = new List<int>();

            tmpList.Add( 35 );
            tmpList.Add( 27 );
            tmpList.Add( 10 );

            Console.WriteLine( tmpList[ 0 ] );
            Console.WriteLine( tmpList[ 1 ] );

            foreach ( int iter in tmpList )
            {
                Console.WriteLine( iter );
            }
            tmpList.Sort();
            foreach ( int iter in tmpList )
            {
                Console.WriteLine( iter );
            }
            List<string> strList = new List<string>();
            strList.Add( "VIPS" );
            strList.Add( "Ashley" );
            strList.Add( "outback" );

            strList.Sort();
            foreach ( string iter in strList )
            {
                Console.WriteLine( iter );
            }
            if ( strList.Contains( "VIPS" ) == true )
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

            foreach ( List<string> iterList in itemList )
            {
                foreach ( string iterStr in iterList )
                {
                    Console.Write( iterStr );
                    Console.Write( " " );
                }
                Console.WriteLine();
            }
            Console.WriteLine( itemList[ 0 ][ 1 ] );
            Console.WriteLine( itemList[ 1 ][ 0 ] );
            Console.WriteLine( itemList[ 2 ][ 2 ] );

            SortedList<string, int> tmpSL = new SortedList<string, int>();

            tmpSL.Add( "Hong", 89 );
            tmpSL.Add( "Lee", 85 );
            tmpSL.Add( "Choi", 75 );
            tmpSL.Add( "Kim", 92 );

            foreach ( KeyValuePair<string, int> iter in tmpSL )
            {
                Console.WriteLine( "{0} : {1}", iter.Key, iter.Value );
            }
            foreach ( string key in tmpSL.Keys )
            {
                Console.WriteLine( "{0} : {1}", key, tmpSL[ key ] );
            }
            tmpSL[ "Jung" ] = 89; //Add
            tmpSL[ "Hong" ] = 95;//Modify
            foreach ( string key in tmpSL.Keys )
            {
                Console.WriteLine( "{0}:{1}", key, tmpSL[ key ] );
            }
            tmpSL[ "choi" ] = 92; //Modify
            Console.WriteLine( "===Score List===" );

            SortedList<int, List<string>> tmpScores = new SortedList<int, List<string>>();
            foreach ( KeyValuePair<string, int> iter in tmpSL )
            {
                string tmpName = iter.Key;
                int tmpScore = iter.Value;

                if ( tmpScores.ContainsKey( tmpScore ) == true )
                {
                    tmpScores[ tmpScore ].Add( tmpName );
                }
                else
                {
                    List<string> tmpArrs = new List<string>();
                    tmpArrs.Add( tmpName );
                    tmpScores.Add( tmpScore, tmpArrs );
                }
            }
            foreach ( int iterScore in tmpScores.Keys.Reverse() )
            {
                Console.Write( "{0} : ", iterScore );
                foreach ( string iterName in tmpScores[ iterScore ] )
                {
                    Console.Write( "{0}, ", iterName );
                }
                Console.WriteLine();
            }

            Console.WriteLine( "===TEPS List===" );

            SortedList<string, List<int>> tmpTEPS = new SortedList<string, List<int>>();

            Random rand = new Random();
            String[] tNames = { "Kwak", "Goo", "Park", "Yoo", "Lim" };
            foreach(string iter in tNames)
            {
                List<int> tScores = new List<int>();
                int tCount = rand.Next() % 7 + 4;
                for(int i=0;i<tCount;i++)
                {
                    tScores.Add( rand.Next() % 700 + 300 );
                }
                tmpTEPS.Add( iter, tScores );
            }
            foreach(string iterName in tmpTEPS.Keys)
            {
                int tmpSum = 0;
                Console.Write( "{0,5}", iterName );
                foreach(int iterScore in tmpTEPS[iterName])
                {
                    tmpSum += iterScore;
                }
                Console.Write( "({0:F2}):", (float) tmpSum / (float) tmpTEPS[ iterName ].Count );
                foreach(int iterScore in tmpTEPS[iterName])
                {
                    Console.Write( "{0,4},", iterScore );
                }
                Console.WriteLine();
            }

            Console.WriteLine( "===LINQ Sample===" );

            var tmpData = from iterName in tmpTEPS
                          where iterName.Value.Max() > 650
                          orderby iterName.Value.Max() descending
                          select new
                          {
                              Name = iterName.Key,
                              Average = iterName.Value.Max(),
                              Scores = iterName.Value
                          };
            foreach(var iter in tmpData)
            {
                Console.Write( "{0:5}", iter.Name );
                Console.Write( "{0:F2}:", iter.Average );
                foreach(int iterScore in iter.Scores)
                {
                    Console.Write( "{0,4}", iterScore );
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}