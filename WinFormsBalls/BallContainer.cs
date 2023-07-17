using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBalls
{
    public class BallContainer
    {
        //ballCollection.Add(new Ball(pictureBox1.Width / 2, pictureBox1.Height / 2));
        private const int countBall = 10;
        public List<Ball> ballCollection { get; set; }

        private int _width;
        private int _height;

        public BallContainer(int width, int height) 
        {
            _width = width;
            _height = height;

            ballCollection = new List<Ball>(countBall);
            for (int i = 0; i < countBall; i++)
            {
                ballCollection.Add(new Ball(_width / 2, _height / 2));
            }
        }

        public void move ()
        {
            for (int i = 0; i < countBall; i++)
            {
                if (ballCollection[i].xPoint > _width - ballCollection[i].saize || ballCollection[i].xPoint < 0)
                {
                    ballCollection[i].xSpeed *= -1;
                }

                if (ballCollection[i].yPoint > _height - ballCollection[i].saize || ballCollection[i].yPoint < 0)
                {
                    ballCollection[i].ySpeed *= -1;
                }

                ballCollection[i].xPoint += ballCollection[i].xSpeed;
                ballCollection[i].yPoint += ballCollection[i].ySpeed;
            }
        }
    }
}
