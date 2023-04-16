using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LogicApi()
        {

        }
    }
}


