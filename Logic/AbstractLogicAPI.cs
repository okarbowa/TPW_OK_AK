using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Logic
{
    public abstract class AbstractLogicAPI
    {
        public static AbstractLogicAPI CreateAPI()
        {
            return new BallControl();
        }

        public abstract ObservableCollection<Ball> getCollection();
        public abstract void CreateBall(int numberOfBalls);
        public abstract void MoveBall(Ball ball, double numberOfFrames, double duration, PointF vector);
        public abstract PointF FindNewBallPosition(Ball ball, int numberOfFrames);
        public abstract void BallsMovement();
    }
}
