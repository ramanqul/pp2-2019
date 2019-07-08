using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyPaint
{


    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Bitmap bitmap;

        private Point mouseBeginPoint;
        private Point mouseEndPoint;

        private Pen pen = new Pen(Color.Black);
        private Color BgColor = Color.White;

        private bool isDrawing = false;

        private ShapeType selectedShape = ShapeType.Pencil;

        private Shape currentShape;
        private List<Shape> shapes;
        

        /*
         Hint how to get pixel color: bitmap.GetPixel(x, y);
        */

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.Clear(BgColor);

            pictureBox1.Image = bitmap;
            shapes = new List<Shape>();
        }

        /*
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
        */

        private void FillShape(Point clickedPoint, Color color)
        {
            Queue<Point> queue = new Queue<Point>();

            queue.Enqueue(clickedPoint);


            while (queue.Count > 0)
            {
                //Console.WriteLine("Size of queue is {0}", queue.Count);

                Point p = queue.Dequeue();

                Color pixelColor = bitmap.GetPixel(p.X, p.Y);

                //Console.WriteLine("Color is {0} at pixel {1} {2}", pixelColor, p.X, p.Y);


                if (pixelColor.ToArgb() == BgColor.ToArgb())
                {
                    bitmap.SetPixel(p.X, p.Y, color);
                    

                    queue.Enqueue(new Point(p.X + 1, p.Y));
                    queue.Enqueue(new Point(p.X, p.Y+1));
                    queue.Enqueue(new Point(p.X-1, p.Y));
                    queue.Enqueue(new Point(p.X, p.Y-1));
                }
            }

            pictureBox1.Image = bitmap;

        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseBeginPoint = e.Location;
            isDrawing = true;

            if (selectedShape == ShapeType.Fill)
            {
                FillShape(e.Location, Color.Red);
            }

            Console.WriteLine("Mouse has been clicked");
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {

                currentShape = GetShape(selectedShape, mouseBeginPoint, mouseEndPoint);

                mouseEndPoint = e.Location;
                //draw
                pictureBox1.Refresh();

                Console.WriteLine("Mouse has been moved!");
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shapes.Add(currentShape);

            isDrawing = false;
            currentShape = null;

            Console.WriteLine("Mouse has been released");
        }

        private void DrawShape(Shape s)
        {
            if (s is MyPencil) {

                MyPencil p = s as MyPencil;

                if (p.Points.Count < 1)
                {
                    return;
                }

                for (int i=1;i<p.Points.Count;i++)
                {
                    graphics.DrawLine(pen, p.Points[i - 1], p.Points[i]);
                }

            }
            else if (s is MyRectangle)
            {
                MyRectangle r = s as MyRectangle;
                graphics.DrawRectangle(pen,
                    r.Location.X, r.Location.Y, r.Width, r.Height);

            }
            else if (s is MyCircle)
            {
                MyCircle circle = s as MyCircle;

                graphics.DrawEllipse(pen,
                    circle.Location.X, circle.Location.Y,
                    circle.Width, circle.Height);
            }
            else if (s is MyLine)
            {
                MyLine l = s as MyLine;

                graphics.DrawLine(pen, l.Location, l.EndLocation);
            }

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                graphics.Clear(BgColor);


                //draw previous shapes
                foreach (var s in shapes)
                {
                    DrawShape(s);
                }

                //draw current shape
                DrawShape(currentShape);
            }
        }

        private Point GetMinPoint(Point p1, Point p2)
        {
            if (p1.X > p2.X && p1.Y < p2.Y)
            {
                return new Point(p2.X, p1.Y);
            }
            else if (p1.Y > p2.Y && p1.X < p2.X)
            {
                return new Point(p1.X, p2.Y);
            }

            double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);
            double d2 = Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);

            if (d1 > d2)
            {
                return p2;
            }
            else
            {
                return p1;
            }
        }

        private Shape GetShape(ShapeType type, Point p1, Point p2)
        {
            if (type == ShapeType.Rectangle)
            {
                MyRectangle r = new MyRectangle();

                int w = Math.Abs(p1.X - p2.X);
                int h = Math.Abs(p1.Y - p2.Y);

                r.Location = GetMinPoint(p1, p2);
                r.Height = h;
                r.Width = w;

                return r;
            }
            else if (type == ShapeType.Circle)
            {
                MyCircle r = new MyCircle();

                int w = Math.Abs(p1.X - p2.X);
                int h = Math.Abs(p1.Y - p2.Y);

                r.Location = GetMinPoint(p1, p2);
                r.Height = h;
                r.Width = w;

                return r;
            }
            else if (selectedShape == ShapeType.Line)
            {
                MyLine line = new MyLine();
                line.Location = p1;
                line.EndLocation = p2;



                return line;
            } else
            {
                if (currentShape == null)
                {
                    MyPencil newPencil = new MyPencil();

                    newPencil.Points.Add(p1);
                    return newPencil;
                }

                MyPencil p = currentShape as MyPencil;

                p.Points.Add(p2);

                return p;
            }

        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Rectangle;
            Console.WriteLine("Selected shape is {0}", selectedShape);
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Circle;
            Console.WriteLine("Selected shape is {0}", selectedShape);
        }

        private void Line_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Line;
            Console.WriteLine("Selected shape is {0}", selectedShape);
        }
        private void Pencil_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Pencil;

            Console.WriteLine("Selected shape is {0}", selectedShape);
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            selectedShape = ShapeType.Fill;
        }

    }
}
