using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Program
    {
        public delegate int calculate( int a, int b );

        public static int Plus(int a,int b)
        {
            Console.WriteLine( "{0}+{1}={2}", a, b, a + b );
            return (a + b);
        }
        public static int Minus(int a,int b)
        {
            Console.WriteLine( "{0}-{1}={2}", a, b, a - b );
            return (a - b);
        }
        public static int Multiply( int a, int b )
        {
            Console.WriteLine( "{0}*{1}={2}", a, b, a * b );
            return (a * b);
        }
        public static int Divide( int a, int b )
        {
            Console.WriteLine( "{0}/{1}={2}", a, b, a - b );
            return (a / b);
        }

        public calculate DelegateOper;
        public event calculate EventOper;
        
        static void Main( string[] args )
        {
            calculate cal1;
            cal1 = new calculate( Plus );
            int res1 = cal1( 3, 5 );
            Console.WriteLine( "return:{0}", res1 );

            calculate cal2;
            cal2 = new calculate( Multiply );
            int res2 = cal2( 4,5 );
            Console.WriteLine( "return:{0}", res2 );

            cal1 = new calculate( Divide );
            int res3 = cal1( 10, 5 );
            Console.WriteLine( "return:{0}", res3 );

            calculate tmpOperation;
            tmpOperation = new calculate( Plus );
            tmpOperation = new calculate( Minus );

            tmpOperation( 8, 9 );

            tmpOperation += new calculate( Multiply );
            tmpOperation += new calculate( Divide );

            tmpOperation( 3, 2 );

            Console.WriteLine( "Remove" );
            tmpOperation -= new calculate( Minus );
            tmpOperation( 7, 3 );


            tmpOperation += delegate( int a, int b )
            {
                Console.WriteLine( "{0}%{1}={2}", a, b, a % b );
                return (a % b);
            };
            
            tmpOperation(4,3);

            Program tmpPrg = new Program();

            tmpPrg.DelegateOper = new calculate( Plus );
            tmpPrg.DelegateOper += new calculate( Multiply );
            tmpPrg.DelegateOper( 2, 3 );


            tmpPrg.EventOper = new calculate( Minus );
            tmpPrg.EventOper = new calculate( Divide );
            tmpPrg.EventOper( 4, 5 );


            Console.ReadKey();

           
   
        }
    }
}
