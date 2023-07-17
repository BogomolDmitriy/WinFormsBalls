using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBalls
{
    public class Ball
    {
        public Color color { get; set; }
        public Brush brush { get; set; }
        public int saize { get; set; }
        //public Point PointBall { get; set; }
        public int xPoint { get; set; }
        public int yPoint { get; set; }
        public int xSpeed { get; set; }
        public int ySpeed { get; set; }
        //public int mas { get; set; }

        public Ball( int x, int y)
        {
            Random rnd = new Random();
            //PointBall = new Point(x, y);
            xPoint = x;
            yPoint = y;

            color = Color.FromArgb(rnd.Next(0, 254), rnd.Next(0, 254), rnd.Next(0, 254));
            brush = new SolidBrush(color);
            saize = rnd.Next(50, 140);
            xSpeed = rnd.Next(10, 40);
            ySpeed = rnd.Next(10, 40);
        }
    }
}
