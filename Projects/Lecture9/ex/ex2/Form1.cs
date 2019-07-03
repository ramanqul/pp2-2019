using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        private SolidBrush brush = new SolidBrush(Color.Green);

        private int x = 1;
        private int y = 100;
        private int dirX = 10;
        private int dirY = 0;

        private int rectangleWidth = 200;
        private int rectangleHeight = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, x, y, rectangleWidth, rectangleHeight);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            x = x + dirX;

            if (x >= Width - rectangleWidth || x <= 0)
            {
                dirX = -dirX;
            }

            Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush = new SolidBrush(colorDialog1.Color);
            }
        }
    }
}
