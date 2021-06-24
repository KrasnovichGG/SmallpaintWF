using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallpaintWF
{
    public partial class Рисовашка : Form
    {
        public Рисовашка()
        {
            InitializeComponent();
            SetSize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(pCbox1.BackColor);
            pCbox1.Image = map;
        }

        private void trackBar_panel1_Scroll(object sender, EventArgs e)
        {

        }
        private class ArrayPoints
        {
            private int index = 0;
            public Point[] points;
            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if(index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void pCbox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pCbox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void pCbox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse)
            {
                return;
            }
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pCbox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void trackBar_panel1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar_panel1.Value;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG) | *.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(pCbox1.Image != null)
                {
                    pCbox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void panel_trackbara_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
