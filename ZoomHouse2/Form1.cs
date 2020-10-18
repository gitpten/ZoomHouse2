using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomHouse2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            DrawShip();
            DrawHouse();
        }

        private void DrawHouse()
        {

            int gap = tbGap.Value;
            int size = tbSize.Value;

            Pen pen = new Pen(Color.Blue, 2);

            int w = size;
            int h = w;
            Point p1 = new Point(gap, gap + h / 2);

            g.DrawRectangle(pen, p1.X, p1.Y, w, h);

            Point p2 = new Point(p1.X + w, p1.Y);
            Point p3 = new Point(p1.X + w / 2, p1.Y - h / 2);
            g.FillPolygon(Brushes.Brown, new Point[] { p1, p2, p3 });
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            DrawShip();
            DrawHouse();
        }

        private void tbD_Scroll(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            DrawShip();
            DrawHouse();
        }

        private void DrawShip()
        {
            int d = tbD.Value;

            Point p0 = new Point(tbX0.Value, tbY0.Value);

            Point p1 = new Point(p0.X + 8 * d, p0.Y);
            Point p4 = new Point(p0.X, p0.Y + 8 * d);
            Point p5 = new Point(p0.X + 20 * d, p4.Y);
            Point p3 = new Point(p1.X, p0.Y + 5 * d / 2);
            Point p2 = new Point(p1.X + 2 * d, p1.Y + 3 * d / 2);

            Pen pen = new Pen(Color.Red, 3);

            Brush brush1 = new SolidBrush(Color.Red);
            Brush brush2 = new HatchBrush(HatchStyle.DarkVertical, Color.Red, Color.Black);
            Brush brush3 = new TextureBrush(Image.FromFile("pattern.jpg"));
            Brush brush4 = new LinearGradientBrush(new Point(0, 0), new Point(600, 600), Color.Yellow, Color.Green);

            g.FillPolygon(brush4, new Point[] { p1, p2, p3, p4, p5, p3 });

            
        }
    }
}
