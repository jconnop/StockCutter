using Xunit;
using StockCutter.Model;

namespace StockCutterTests.Model
{
    public class ItemTest
    {
        [Fact]
        public void TestItemCreation()
        {
            Item i = new Item(500);
            Assert.Equal(i.Size, 500);
        }
    }
}
