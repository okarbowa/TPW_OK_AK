namespace Data
{
    public abstract class AbstractDataAPI
    {
        public static AbstractDataAPI CreateAPI()
        {
            return new DataApi();
        }

       
    }

    internal class DataApi : AbstractDataAPI
    {

    }

}
