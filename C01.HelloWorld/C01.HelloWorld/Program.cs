using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
           // Console.ReadKey();

            int tmpX;
            int tmpY;
            tmpX = 7;
            tmpY = 8;

            Console.WriteLine( "%d + %d = %d ", tmpX, tmpY, tmpX + tmpY );
            Console.WriteLine( "{0} + {1} = {2}", tmpX, tmpY, tmpX + tmpY );


            Console.WriteLine("{0} + {1} = {2} ({0},{1})",tmpX,tmpY,tmpX+tmpY);
            Console.WriteLine( "{0} + {1} = {2}", tmpX.ToString(), tmpY.ToString() 
                ,tmpX.ToString()+tmpY.ToString());

            Console.WriteLine( "{0} + {1} = {2}", tmpX.ToString(), tmpY.ToString()
             ,(tmpX+tmpY).ToString());

            string tmpName = "Class";
            String tmpLang = "C#";

            Console.WriteLine( "{0} : {1}", tmpName, tmpLang );

            Console.WriteLine( "{0}", tmpName + " : " + tmpLang );
          
            Console.ReadKey();
        }
    }
}
