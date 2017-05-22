using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03_02
{
    class CPoint4i
    {
        public int theX;
        public int theY;
        public int theZ;
        public int theW;
        public CPoint4i()
        {
            theX = 0;
            theY = 0;
            theZ = 0;
            theW = 0;
        }

        public int this[ int aIndex ]
        {
            get
            {
                if ( aIndex == 0 ) return (theX);
                if ( aIndex == 1 ) return (theY);
                if ( aIndex == 2 ) return (theZ);
                if ( aIndex == 3 ) return (theW);
                return (0);
            }
            set
            {
                if ( aIndex == 0 ) { theX = value; }
                if ( aIndex == 1 ) { theY = value; }
                if ( aIndex == 2 ) { theZ = value; }
                if ( aIndex == 3 ) { theW = value; }
            }
        }

        public int this[ string aStr ]
        {
            get
            {
                if ( aStr.Equals( "X" ) == true ) return (theX);
                if ( aStr.Equals( "Y" ) == true ) return (theY);
                if ( aStr.Equals( "Z" ) == true ) return (theZ);
                if ( aStr.Equals( "W" ) == true ) return (theW);
                return (0);
            }
            set
            {
                if ( aStr.Equals( "X" ) == true ) { theX = value; }
                if ( aStr.Equals( "Y" ) == true ) { theY = value; }
                if ( aStr.Equals( "Z" ) == true ) { theZ = value; }
                if ( aStr.Equals( "W" ) == true ) { theW = value; }
            }                            
        }

        


    }
}
