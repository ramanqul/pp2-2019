using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bouncer
{
    public partial class Form1 : Form
    {

        private int dirX = 7;
        private int dirY = 7;
        private int x = 0;
        private int y = 0;

        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(blueBrush, x, y, 50, 50);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            x = x + dirX;
            y = y + dirY;

            if (x >= Width-50-dirX || x <= 0)
            {
                dirX = -dirX;
            }

            if (y >= Height-50-dirY || y <= 0)
            {
                dirY = -dirY;
            }

            Refresh();
        }
    }
}
