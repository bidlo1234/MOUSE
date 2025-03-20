using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управляемое_движение_MOUSE
{
    public partial class Form1 : Form
    {
        private Image Bit;
        int x = 100, y = 100, w = 40, h = 40;
        Graphics g;
        bool p = false;//Признак нажатой клавиши

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            g.DrawImage(Bit, x, y, w, h);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p = true;  //Нажали
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            p = false;  //Отпустили
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (p)  //Если нажата, то
            {
                rct.X = x;
                rct.Y = y;
                rct.Width = w;
                rct.Height = h;
                Invalidate(rct);
                if(x> e.X - rct.Width && x< e.X + rct.Width && y> e.Y - rct.Height && y< e.Y + rct.Height)
                {
                    x = e.X - 20;
                    y = e.Y - 20;
                    g.DrawImage(Bit, x, y, w, h);
                }
                
                
            }

        }

        Rectangle rct;
        private void button1_Click(object sender, EventArgs e)
        {
            //g = this.CreateGraphics();
            //g.DrawImage(Bit, 100, 100, w, h);
        }        

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Bit = new Bitmap("F://Programming/Other users/Dima/C#/Управляемое_движение_KeyDown/image.png");

        }
    }
}
