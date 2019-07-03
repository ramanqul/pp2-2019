using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen redPen = new Pen(Color.Red);
            Pen bluePen = new Pen(Color.Blue);

            e.Graphics.DrawLine(redPen, 10, 10, 300, 300);
            e.Graphics.DrawEllipse(redPen, 200, 100, 50, 50);
            e.Graphics.DrawRectangle(bluePen, 150, 50, 200, 200);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(blueBrush, 300, 200, 100, 100);

        }
    }
}
