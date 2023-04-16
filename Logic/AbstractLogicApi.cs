using System.Data;

namespace Logic
{
    public class AbstractLogicApi
    {
        public static AbstractLogicApi CreateApi()
        {
            return new LogicApi();
        }

        public abstract void CreateBall();

    }

    internal class LogicApi : AbstractLogicApi
    {
        public LogicApi() { }
    }
}