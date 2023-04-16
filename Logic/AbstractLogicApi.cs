using System.Data;

namespace Logic
{
    public abstract class AbstractLogicApi
    {
        public static AbstractLogicApi CreateApi()
        {
            return new LogicApi();
        }

        
    }

    internal class LogicApi : AbstractLogicApi
    {
        public LogicApi() { }
    }
}