using System.Windows.Forms;

namespace WinFormsBalls
{
    public partial class Form1 : Form
    {
        //private const int countBall = 10;
        //private List<Ball> ballCollection;
        BallContainer _ballContainer;
        public Form1()
        {
            InitializeComponent();
            _ballContainer = new BallContainer(pictureBox1.Width, pictureBox1.Height);
            //ballCollection = new List<Ball>(countBall);
            //for (int i = 0; i < countBall; i++)
            //{
            //    ballCollection.Add(new Ball(pictureBox1.Width / 2, pictureBox1.Height / 2));
            //}

        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            DrawEllipse();
        }

        
        private void DrawEllipse()
        {
            var graf = pictureBox1.CreateGraphics();
            graf.Clear(Color.White);

            foreach (var item in _ballContainer.ballCollection)
            {
                graf.FillEllipse(item.brush, item.xPoint, item.yPoint, item.saize, item.saize);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawEllipse();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (_x > pictureBox1.Width - defaultSize || _x < 0)
            //{
            //    _xSpeed *= -1;
            //}

            //if (_y > pictureBox1.Height - defaultSize || _y < 0)
            //{
            //    _ySpeed *= -1;
            //}
            //_x += _xSpeed;
            //_y += _ySpeed;
            //DrawEllipse();

            //for (int i = 0; i < countBall; i++)
            //{
            //    if (ballCollection[i].xPoint > pictureBox1.Width - ballCollection[i].saize || ballCollection[i].xPoint < 0)
            //    {
            //        ballCollection[i].xSpeed *= -1;
            //    }

            //    if (ballCollection[i].yPoint > pictureBox1.Height - ballCollection[i].saize || ballCollection[i].yPoint < 0)
            //    {
            //        ballCollection[i].ySpeed *= -1;
            //    }

            //    ballCollection[i].xPoint += ballCollection[i].xSpeed;
            //    ballCollection[i].yPoint += ballCollection[i].ySpeed;
            //    DrawEllipse();
            //}
            _ballContainer.move();
            DrawEllipse();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}