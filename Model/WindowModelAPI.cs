using Data;
using Logic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Numerics;

namespace Model
{
    public abstract class WindowModelAbstractAPI
    {

        public static WindowModelAbstractAPI CreateAPI()
        {
            return new WindowModelAPI();
        }

        public abstract void CreateBall(int numberOfBalls);

        public abstract void MoveBall(int Speed, PointF vector);
        public abstract void InitialMoveBalls();

        public abstract ObservableCollection<Ball> GetCollection();

    }

    internal class WindowModelAPI : WindowModelAbstractAPI
    {
        private AbstractLogicAPI logicAPI;

        public WindowModelAPI()
        {
            logicAPI = AbstractLogicAPI.CreateAPIInstance();
        }


        public override void CreateBall(int numberOfBalls)
        {
            logicAPI.CreateBall(numberOfBalls);
        }

        public override void MoveBall(int Speed, PointF vector)
        {
            logicAPI.MoveBall(Speed,vector);
        }

        public override void InitialMoveBalls()
        {
            logicAPI.InitialMoveBalls();
        }


        public override ObservableCollection<Ball> GetCollection() 
        {
            ObservableCollection<Ball> collection;
            collection = logicAPI.getCollection();
            return collection;
        }

    }
}