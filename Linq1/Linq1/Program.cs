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

            Console.ReadKey();
        }
    }
}
