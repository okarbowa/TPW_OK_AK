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
