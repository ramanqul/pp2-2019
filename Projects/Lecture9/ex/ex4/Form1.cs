using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {

        Graphics graphics;
        Bitmap bitmap;

        private Point mouseBeginPoint;
        private Point mouseEndPoint;
        private Pen pen = new Pen(Color.Black);
        private bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.White);

            pictureBox1.Image = bitmap;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;

                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(bitmap);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseBeginPoint = e.Location;
            isDrawing = true; 

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                mouseEndPoint = e.Location;

                //draw

                graphics.DrawLine(pen, mouseBeginPoint, mouseEndPoint);


                mouseBeginPoint = mouseEndPoint;

                pictureBox1.Refresh();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
