using Logic;

namespace LogicTest
{
    [TestClass]
    public class LogicTest
    {
        [TestMethod]
        public void IsBallCreatedTest()
        {
            AbstractLogicAPI ballManager = AbstractLogicAPI.CreateAPI();
            ballManager.CreateBall(1);
            Assert.AreEqual(ballManager.getCollection().Count(), 1);
        }


        [TestMethod]
        public void doesBallMove()
        {
            AbstractLogicAPI ballManager = AbstractLogicAPI.CreateAPI();
            ballManager.CreateBall(1);
            double tmp_x = ballManager.getCollection()[0].X;
            double tmp_y = ballManager.getCollection()[0].Y;
            ballManager.MoveBall(ballManager.getCollection()[0], 5, 3, new System.Drawing.PointF(10, 10));

            Assert.AreNotEqual(ballManager.getCollection()[0].X, tmp_x);
            Assert.AreNotEqual(ballManager.getCollection()[0].Y, tmp_y);
        }


        [TestMethod]
        public void IsBallInside()
        {
            AbstractLogicAPI ballManager = AbstractLogicAPI.CreateAPI();
            ballManager.CreateBall(1);

            Assert.IsTrue(ballManager.getCollection()[0].X <= 500 - ballManager.getCollection()[0].d);
            Assert.IsTrue(ballManager.getCollection()[0].Y <= 500 - ballManager.getCollection()[0].d);
        }
    }
}