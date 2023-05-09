using Data;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModel
{
    public class WindowViewModel : INotifyPropertyChanged
    {
        private WindowModelAbstractAPI modelAPI;

        public ICommand Apply { get; set; }
        public ICommand Start { get; set; }

        public WindowViewModel()
        {
            modelAPI = WindowModelAbstractAPI.CreateAPI();
            Apply = new Relay(() => modelAPI.CreateBall(numberOfBalls));
            Start = new Relay(() => modelAPI.InitialMoveBalls());
        }

        public ObservableCollection<Ball> ObservCollectionOfBall => modelAPI.GetCollection();

        private int _numberOfBalls;
        public int numberOfBalls
        {
            get { return _numberOfBalls; }
            set
            {
                if (value != _numberOfBalls)
                {
                    _numberOfBalls = value;
                    OnPropertyChanged("numberOfBalls");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}