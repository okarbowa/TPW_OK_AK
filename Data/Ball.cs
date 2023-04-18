using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Data
{
    public class Ball : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; RaisePropertyChanged("X"); }
        }
        public double Y
        {
            get { return y; }
            set { y = value; RaisePropertyChanged("Y"); }
        }

        public double d { get; private set; }
        public double Xdestination { get; set; }
        public double Ydestination { get; set; }

        public Ball(double x, double y, double diameter, double destinationPlaneX, double destinationPlaneY)
        {
            this.X = x;
            this.Y = y;
            this.d = diameter;
            this.Xdestination = destinationPlaneX;
            this.Ydestination = destinationPlaneY;
        }
    }
}
