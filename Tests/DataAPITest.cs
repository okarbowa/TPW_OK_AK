using Data;

namespace Tests
{
    [TestClass]
    public class DataAPITest
    {
        [TestMethod]
        public void CreateAPITest()
        {
            AbstractDataAPI api = AbstractDataAPI.CreateAPI();
            Assert.IsNotNull(api);
        }
    }
}