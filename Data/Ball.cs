using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Data
{
    public class Ball : IBall
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static int d { get; } = 20;

        public PointF Direction { get; set; }

        public PointF Position { get; private set; } = new PointF();

        public int Speed { get; private set; }

        private Thread thread;

        public Ball(float x, float y, int speed)
        {
            this.Position = new PointF(x, y);
            this.Speed = speed;
        }

        public void MoveBall(int Speed, PointF vector)
        {
                thread = new Thread(() =>
                {
                    PointF vector = FindNewBallPosition(Speed);
                    while (true)
                    {
                        if ((vector.X > 0 && this.Position.X > 500 - Ball.d) ||
                            (vector.X < 0 && this.Position.X < 0) ||
                            (vector.Y > 0 && this.Position.Y > 500 - Ball.d) ||
                            (vector.Y < 0 && this.Position.Y < 0))
                        {
                            vector = FindNewBallPosition(Speed);
                        }
                        //notyfikacja warstwy wyższej
                        this.Position = new PointF(Position.X + vector.X, Position.Y + vector.Y);
                        Thread.Sleep(1);
                    }
                });
                thread.Start();
        }

        public PointF FindNewBallPosition(int Speed)
        {
            Random random = new Random();
            this.Direction = new PointF(random.Next(0, 500 - Ball.d), random.Next(0, 500 - Ball.d));
            double length = Math.Sqrt(Math.Pow(this.Position.X - this.Position.X, 2) + Math.Pow(this.Position.Y - this.Position.Y, 2)) * Speed;
            PointF vector = new PointF();
            vector.X = (float)((this.Direction.X - this.Direction.X) / length);
            vector.Y = (float)((this.Direction.Y - this.Direction.Y) / length);
            return vector;
        }
    }
}
