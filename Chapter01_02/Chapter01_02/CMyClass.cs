using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_02
{
    class CMyClass
    {
        public static int Add(int a,int b)
        {
            Console.WriteLine( "{0}+{1}={2}", a, b, a + b );
            return (a + b);
        }
        public int Multiply(int a,int b)
        {
            Console.WriteLine( "{0}*{1}={2}", a, b, a * b );
            return (a * b);
        }
    }
}
