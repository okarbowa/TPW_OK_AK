using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using System.Drawing;
using Data;

namespace Logic
{
    public class BallControl : AbstractLogicAPI
    {
        private ObservableCollection<Ball> _balls = new();
        public override ObservableCollection<Ball> getCollection() { return _balls; }

        public override void CreateBall(int numberOfBalls)
        {
            _balls.Clear();
            Random random = new Random();
            for (int i = 0; i < numberOfBalls; i++)
            {
                int diameter = 20;
                Ball ball = new(random.Next(500 - diameter), random.Next(500 - diameter), diameter, 0, 0);
                _balls.Add(ball);
            }
        }
        public override PointF FindNewBallPosition(Ball ball, int numberOfFrames)
        {
            Random random = new Random();
            ball.Xdestination = random.Next(0, 500 - (int)ball.d);
            ball.Ydestination = random.Next(0, 500 - (int)ball.d);
            double length = Math.Sqrt(Math.Pow(ball.Xdestination - ball.X, 2) + Math.Pow(ball.Ydestination - ball.Y, 2)) * numberOfFrames;
            PointF vector = new PointF();
            vector.X = (float)((ball.Xdestination - ball.X) / length);
            vector.Y = (float)((ball.Ydestination - ball.Y) / length);
            return vector;
        }
        public override void MoveBall(Ball ball, double numberOfFrames, double duration, PointF vector)
        {
            ball.X += vector.X;
            ball.Y += vector.Y;
            Thread.Sleep(1);
        }

        public override void BallsMovement()
        {
            foreach (Ball ball in _balls)
            {
                Thread thread = new Thread(() =>
                {
                    PointF vector = FindNewBallPosition(ball, 5);
                    while (true)
                    {
                        if ((vector.X > 0 && ball.X > 500 - (int)ball.d) ||
                            (vector.X < 0 && ball.X < 0) ||
                            (vector.Y > 0 && ball.Y > 500 - (int)ball.d) ||
                            (vector.Y < 0 && ball.Y < 0))
                        {
                            vector = FindNewBallPosition(ball, 5);
                        }
                        MoveBall(ball, 100, 1, vector);
                    }
                });
                thread.Start();
            }
        }
    }
}
