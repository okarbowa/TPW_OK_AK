using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Ball : BallInterface
    {
        private double x { get; set; }
        private double y { get; set; }
        private double d { get; set; } = 10;
        private double xVelocity { get; set; }
        private double yVelocity { get; set; }


        public Ball(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
