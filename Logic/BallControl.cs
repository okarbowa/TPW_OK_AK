using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using System.Drawing;
using Data;
using System.ComponentModel;
using System.Threading;

namespace Logic
{
    internal class BallControl : AbstractLogicAPI, INotifyPropertyChanged
    {
        //IBall ball;

        private AbstractDataAPI dataAPI=AbstractDataAPI.CreateAPI();

        private ObservableCollection<Ball> _balls = new();

        public event PropertyChangedEventHandler? PropertyChanged;

        public override ObservableCollection<Ball> getCollection() { return _balls; }


        public override void CreateBall(int numberOfBalls)
        {
            _balls.Clear();
            Random random = new Random();
            int speed = random.Next(0, 20);
            for (int i = 0; i < numberOfBalls; i++)
            {
                Ball ball = new(random.Next(500 - Ball.d), random.Next(500 - Ball.d), speed);

                _balls.Add(ball);
            }
        }

        public override void MoveBall(int Speed, PointF vector)
        {
            this.MoveBall(Speed, vector);
        }

        public override void InitialMoveBalls()
        {
            Random random = new Random();
            PointF vector = new PointF(random.Next(0, 500 - Ball.d), random.Next(0, 500 - Ball.d));
            foreach (Ball ball in _balls)
            {
                ball.MoveBall(ball.Speed, vector);
            }
        }


    }
}
