using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Chapter03_01
{
    class Program
    {
        static void Main( string[] args )
        {
            int[] Numbers = new int[ 2 ]; //new 로 할당 
            Numbers[ 0 ] = 10;
            Numbers[ 1 ] = 15;
            Console.WriteLine( Numbers[ 0 ] );
            Console.WriteLine( Numbers[ 1 ] );

            int[] nums = new int[] { 2, 3, 5, 8, 13 };
            Console.WriteLine( nums[ 0 ] );
            Console.WriteLine( nums[ 3 ] );

            int i;
            Console.WriteLine();
            Console.Write( "Num: " );
            for ( i = 0; i < nums.Length;i++ )
            {
                Console.Write( "{0}", nums[ i ] );
            }

            int[] num2s = { 3, 1, 4, 1, 5, 9, 2 };
            Console.WriteLine();
            Console.Write( "num2s : " );
            for ( i = 0; i < num2s.Length;i++ )
            {
                Console.Write( "{0},", num2s[ i ] );
            }

            Console.WriteLine();
            Console.Write( "num2s : " );
            foreach(int iter in num2s)
            {
                Console.Write( "{0},", iter );
            }

            String[ , ] tmpStrLists = { { "Apple", "Banana", "Lemon" }, { "Pizza", "Pasta", "Risoto" } };
            Console.WriteLine();
            Console.WriteLine( tmpStrLists[ 0, 1 ] );
            Console.WriteLine( tmpStrLists[ 1, 2 ] );

            int j;
            for ( i = 0; i < tmpStrLists.GetLength( 0 );i++ )
            {
                for(j=0;j<tmpStrLists.GetLength(1);j++)
                {
                    Console.Write( "{0},", tmpStrLists[ i, j ] );
                }
                Console.WriteLine();
            }
            
            foreach(String iter in tmpStrLists)
            {
                Console.Write( "{0},", iter );
            }

            ArrayList tmpAL = new ArrayList();
            tmpAL.Add( 10 );
            tmpAL.Add( "AAA" );
            tmpAL.Add( 20 );
            tmpAL.Add( "BBB" );
            tmpAL.Add( 30 );
            Console.WriteLine( tmpAL[ 0 ] );
            Console.WriteLine( tmpAL[ 3 ] );

            Console.WriteLine();
            for(i=0;i<tmpAL.Count;i++)
            {
                Console.Write( "{0},", tmpAL[ i ] );
            }
            Console.WriteLine();
            foreach(Object iter in tmpAL)
            {
                Console.Write( "{0},", iter );
            }

            int sum = 0;
            foreach(Object iter in tmpAL)
            {
                if(iter is int)
                {
                    int tmpValue = (int) iter;
                    sum += tmpValue;
                }
            }
            Console.WriteLine();
            Console.WriteLine( "Sum :{0}", sum );

            tmpAL[ 0 ] = 333;
            tmpAL.Insert( 1, "333" );
            Console.WriteLine();
            foreach(Object iter in tmpAL)
            {
                Console.Write( "{0},", iter );
            }
            if(tmpAL.Contains(333)==true)
            {
                Console.WriteLine( "Find!!" );
            }

            tmpAL.RemoveAt( 0 );
            tmpAL.Remove( "AAA" );
            Console.WriteLine();
            foreach(Object iter in tmpAL)
            {
                Console.Write( "{0},", iter );
            }

            Queue tmpQ = new Queue();
            tmpQ.Enqueue( 10 );
            tmpQ.Enqueue( "AAA" );
            tmpQ.Enqueue( 20 );
            Console.WriteLine( tmpQ.Peek() );

            tmpQ.Enqueue( "BBB" );
            tmpQ.Enqueue( 30 );
            Console.WriteLine( tmpQ.Peek() );

            Console.WriteLine();
            foreach ( Object iter in tmpQ )
            {
                Console.Write( "{0},", iter );
            }

            tmpQ.Dequeue();
            tmpQ.Dequeue();

            Console.WriteLine();
            foreach(Object iter in tmpQ)
            {
                Console.Write( "{0},", iter );
            }

            Console.WriteLine();
            while(tmpQ.Count>0)
            {
                object obj = tmpQ.Dequeue();
                Console.Write( "{0},", obj );
            }
            Console.WriteLine( "Count:{0}", tmpQ.Count );




            Console.ReadKey();
        }
    }
}
