using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main( string[] args )
        {
            string[] words = { "Hello", "Program", "C#", "Collections", "Threading" };
            foreach(string iter in words)
            {
                if(iter.Length>5)
                {
                    Console.WriteLine( iter );
                }
            }
            Console.WriteLine( "===Linq1===" );
            IEnumerable<string> resWords1 = words.Where( x => x.Length > 5 );
            foreach(string iter in resWords1)
            {
                Console.WriteLine( iter );
            }

            Console.WriteLine( "===Linq2===" );
            var resWords2 = from iter in words
                            where iter.Length > 5
                            select iter;
            foreach(string iter in resWords2)
            {
                Console.WriteLine( iter );
            }
            Console.WriteLine( "===Linq3===" );
            var resWords3 = words.Where( x => x.Length > 5 ).Select( x => x.Substring( 0, 5 ) );
            foreach(string iter in resWords3)
            {
                Console.WriteLine( iter );
            }

            Console.WriteLine( "===Linq4===" );
            var resWords4 = from iter in words
                            where iter.Length > 5
                            select iter.Substring(0,5);
            foreach ( string iter in resWords4 )
            {
                Console.WriteLine( iter );
            }

            Console.WriteLine( "===Linq5===" );
            var resWords5 = words.Where( x => x.Contains( "o" ) );
            foreach(string iter in resWords5)
            {
                Console.WriteLine( iter );
            }

            Console.WriteLine( "===Linq6===" );
            var resWords6 = from iter in words
                            where iter.Contains( "o" )
                            select iter;
            foreach(string iter in resWords6)
            {
                Console.Write( iter );
            }

            Console.WriteLine( "===Linq7===" );
            var resWords7 = words
                .Where( x => x.Contains( "o" ) )
                .Select( x =>
                {
                    int tmpIdx = x.IndexOf( "o" );
                    return (x.Substring( 0, tmpIdx + 1 ));
                } );
            foreach(string iter in resWords7)
            {
                Console.WriteLine( iter );
            }

            Console.WriteLine( "===Linq8===" );
            var resWords8 = from iter in words
                            where iter.Contains( "o" )
                            select iter.Substring( 0, iter.IndexOf( "o" ) + 1 );
            foreach(string iter in resWords8)
            {
                Console.WriteLine( iter );
            }

            int[] numbers = { 35, 10, 27, 31, 23, 30, 40, 74, 81, 56, 45, 93 };

            var resNums1 = numbers.Where( x => x > 30 );
            var resNums2 = from num in numbers
                           where num > 30
                           select num;
            PrintNumbers( 1, resNums1 );
            PrintNumbers( 2, resNums2 );

            var resNums3 = numbers.Where( num => 10 < num && num < 30 );
            var resNums4 = from num in numbers
                           where 10 < num && num < 30
                           select num;
            PrintNumbers( 3, resNums3 );
            PrintNumbers( 4, resNums4 );

            PrintNumbers( 3, resNums3 );
            PrintNumbers( 4, resNums4 );

            var resNums5 = numbers.Where( ( num, idx ) => num > 10 && idx < 5 );
            PrintNumbers( 5, resNums5 );

            var resNums6 = numbers.Where( ( num, idx ) => (num > 10 && idx < 5) || (num > 50 && idx >= 5) );
            PrintNumbers( 6, resNums6 );

            var resNums7 = numbers.OrderBy( num => num );
            var resNums8 = from num in numbers
                           orderby num
                           select num;
            PrintNumbers( 7, resNums7 );
            PrintNumbers( 8, resNums8 );

            var resNums9 = numbers.OrderByDescending( num => num );
            var resNums10 = from num in numbers
                           orderby num descending
                           select num;
            PrintNumbers( 9, resNums9 );
            PrintNumbers( 10, resNums10 );


            var resNums11 = numbers.OrderBy( num => (num % 10) * 10 + num / 10 );
            var resNums12 = from num in numbers
                            orderby (num % 10) * 10 + num / 10
                            select num;
            PrintNumbers( 11, resNums11 );
            PrintNumbers( 12, resNums12 );

            var resNums13 = numbers.OrderBy( num => num / 10 );
            var resNums14 = from num in numbers
                            orderby num / 10
                            select num;
            PrintNumbers( 13, resNums13 );
            PrintNumbers( 14, resNums14 );

            var resNums15 = numbers.OrderBy( num => num % 10 );
            var resNums16 = from num in numbers
                            orderby num % 10
                            select num;
            PrintNumbers( 15, resNums15 );
            PrintNumbers( 16, resNums16 );

            var resNums17 = numbers.Where( x => x < 40 ).OrderBy( x => x );
            var resNums18 = from x in numbers
                            orderby x < 40
                            select x;
            PrintNumbers( 17, resNums17 );
            PrintNumbers( 18, resNums18 );

            var resNums19 = numbers.Where( x => x < 40 ).OrderByDescending( x => x );
            var resNums20 = from x in numbers
                            orderby x < 40 descending
                            select x;
            PrintNumbers( 19, resNums19 );
            PrintNumbers( 20, resNums20 );

            Console.WriteLine( "Count:{0}", resNums19.Count() );
            Console.WriteLine( "Max:{0}", resNums19.Max() );
            Console.WriteLine( "Min:{0}", resNums19.Min() );
            Console.WriteLine( "Average:{0}", resNums19.Average() );






            Console.ReadKey();
        }
        public static void PrintNumbers(int aIndex,IEnumerable<int> aNums)
        {
            Console.WriteLine( "===Linq Number {0} ===", aIndex );
            foreach(int iter in aNums)
            {
                Console.Write( iter + ", " );
            }
            Console.WriteLine();
        }
    }
}
