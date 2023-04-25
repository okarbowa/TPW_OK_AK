using Data;
using Logic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace Model
{
    public abstract class WindowModelAbstractAPI
    {

        public static WindowModelAbstractAPI CreateAPI()
        {
            return new WindowModelAPI();
        }

        public abstract void CreateBall(int numberOfBalls);
        public abstract void BallsMovement();

        public abstract ObservableCollection<Ball> GetCollection();

    }

    internal class WindowModelAPI : WindowModelAbstractAPI
    {
        private AbstractLogicAPI logicAPI;

        public WindowModelAPI()
        {
            logicAPI = AbstractLogicAPI.CreateAPI();
        }


        public override void CreateBall(int numberOfBalls)
        {
            logicAPI.CreateBall(numberOfBalls);
        }
        public override void BallsMovement()
        {
            logicAPI.BallsMovement();
        }

        public override ObservableCollection<Ball> GetCollection() 
        {
            ObservableCollection<Ball> collection;
            collection = logicAPI.getCollection();
            return collection;
        }

    }
}