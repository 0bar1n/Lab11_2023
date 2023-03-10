using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Lab11
{
    public partial class Form1 : Form

    {

        SolidBrush center = new SolidBrush(Color.PaleGoldenrod);
        SolidBrush green = new SolidBrush(Color.ForestGreen);
        SolidBrush l1 = new SolidBrush(Color.Coral);
        SolidBrush l2 = new SolidBrush(Color.PaleVioletRed);
        SolidBrush l3 = new SolidBrush(Color.OrangeRed);
        SolidBrush l4 = new SolidBrush(Color.IndianRed);
        SolidBrush l5 = new SolidBrush(Color.Salmon);
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.LightGoldenrodYellow);
            g.FillRectangle(center, 0, 340, 400, 100);

            Point point1 = new Point(100, 120);
            Point point2 = new Point(140, 80);
            Point point3 = new Point(70, 50);
            Point[] l1Points =
            {
            point1,
            point2,
            point3,
 };
            g.FillPolygon(l1, l1Points);

            Point point4 = new Point(200, 70);
            Point point5 = new Point(130, 120);
            Point point6 = new Point(70, 90);
            Point[] l2Points =
            {
            point4,
            point5,
            point6,
 };
            g.FillPolygon(l2, l2Points);

            Point point7 = new Point(40, 70);
            Point point8 = new Point(140, 90);
            Point point9 = new Point(100, 120);
            Point[] l3Points =
            {
            point7,
            point8,
            point9,
 };
            g.FillPolygon(l3, l3Points);

            Point point10 = new Point(100, 110);
            Point point11 = new Point(130, 105);
            Point point12 = new Point(117, 130);
            Point[] grPoints =
            {
            point10,
            point11,
            point12,
 };
            g.FillPolygon(green, grPoints);

            Point point13 = new Point(245, 175);
            Point point14 = new Point(247, 130);
            Point point15 = new Point(300, 120);
            Point[] l4Points =
            {
            point13,
            point14,
            point15,
 };
            g.FillPolygon(l4, l4Points);

            g.FillEllipse(center, 100, 90, 20, 20);
            g.FillEllipse(center, 250, 150, 10, 10);

            Pen pen1 = new Pen(Brushes.ForestGreen, 5);
            pen1.DashStyle = DashStyle.Dash;
            g.DrawLine(pen1, new Point(116, 115), new Point(190,390));
            g.DrawLine(pen1, new Point(240, 110), new Point(210, 390));

            Pen pen2 = new Pen(Brushes.Green, 3);
            g.DrawLine(pen2, new Point(247, 170), new Point(210, 390));
            g.DrawLine(pen2, new Point(170, 150), new Point(195, 390));
            g.DrawLine(pen2, new Point(220, 160), new Point(200, 390));

            using (var br = new SolidBrush(Color.FromArgb(110, 0, 30, 220)))
            {
                Point point1a = new Point(130, 190);
                Point point1b = new Point(250, 190);
                Point point1c = new Point(160, 395);
                Point point1d = new Point(230, 395);
                Point[] glass =
                {
            point1a,
            point1b,
            point1d,            
            point1c,
                };
                g.FillPolygon(br, glass);
                g.FillEllipse(br, 157, 378, 75, 17);
            }
            g.FillEllipse(l5, 200, 145, 40, 40);
            g.FillEllipse(l5, 145, 110, 50, 50);
            g.FillEllipse(l3, 210, 40, 70, 70);

            Pen pen3 = new Pen(Brushes.Red, 4);
            pen3.DashStyle = DashStyle.DashDot;
            g.DrawEllipse(pen3, 200, 145, 40, 40);
            g.DrawEllipse(pen3, 145, 110, 50, 50);

        }
    }
}