using Logic;

namespace Model
{
    public abstract class WindowModelAbstractAPI
    {
        public AbstractLogicAPI logicAPI;

        public static WindowModelAbstractAPI CreateAPI()
        {
            return new WindowModelAPI();
        }
        
    }

    internal class WindowModelAPI : WindowModelAbstractAPI
    {
        
        public WindowModelAPI()
        {
            logicAPI = AbstractLogicAPI.CreateAPI();
        }
    }
}