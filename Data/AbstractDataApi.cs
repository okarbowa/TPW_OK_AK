namespace Data
{
    public abstract class AbstractDataApi
    {
        public static AbstractDataApi CreateApi()
        {
            return new DataApi();
        }

       
    }

    internal class DataApi : AbstractDataApi
    {

    }

}