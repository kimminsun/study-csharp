using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            thePen = new Pen( Color.Red );
            theBrush = new SolidBrush( Color.Green );
            theFont = new Font( "굴림", 15 );

            imgList = new List<Image>();

            int i;
            for(i=0;i<16;i++)
            {
                String tmpName = String.Format( "pic_{0}.png", (char) (97 + i) );
                Image tmpI = Image.FromFile( tmpName );
                imgList.Add( tmpI );
            }
        }
        Pen thePen;
        Brush theBrush;
        Font theFont;

        List<Image> imgList;

        int srcX = 50;
        int srcY = 50;


        private void Form1_Paint( object sender, PaintEventArgs e )
        {
            String strTime = String.Format( "Time:{0:D3}", 99 );

            e.Graphics.DrawRectangle( thePen, 0, 0, 100, 10 );
            e.Graphics.DrawString( strTime, theFont, theBrush, 0, 10 );

            int i;
            for(i=0;i<16;i++)
            {
                e.Graphics.DrawImage( imgList[ i ],
                    srcX + (i % 4) * 100, srcY + (i / 4) * 100, 100, 100 );
            }

        }
    }
}
