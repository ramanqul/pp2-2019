using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Blue;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw Triangle
            /*
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(0, 0, 100, 100);
            gp.AddLine(100, 100, 300, 0);
            gp.AddLine(300, 0, 0, 0);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            e.Graphics.FillPath(blackBrush, gp);
            */


            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(50, 0, 25, 80);
            gp.AddLine(25, 80, 105, 25);
            gp.AddLine(105, 25, 5, 25);
            gp.AddLine(5, 25, 75, 80);
            gp.AddLine(75, 80, 50, 0);
            Pen p = new Pen(Color.Red);
            e.Graphics.DrawPath(p, gp);

            string drawString = "Hello World Text";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 50.0F;

            StringFormat drawFormat = new StringFormat();
            e.Graphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);


            
        }
    }
}
