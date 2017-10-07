using Xunit;
using StockCutter.Model;

namespace StockCutterTests.Model
{
    public class BinTest
    {
        [Fact]
        public void TestBinCreation()
        {
            Bin b = new Bin(1000);
            Assert.Equal(b.Capacity, 1000);
            Assert.Equal(b.FreeCapacity, 1000);
            Assert.Equal(b.UsedCapacity, 0);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(1000, 500, 300, 100)]
        [InlineData(1, 1)]
        [InlineData(500, 200, 200, 100)]
        public void TestItemAdding(int capacity, params int[] sizes)
        {
            Bin b = new Bin(capacity);
            int expectedSum = 0;
            foreach(int size in sizes)
            {
                Item i = new Item(size);
                b.Add(i);
                expectedSum += size;
            }

            Assert.Equal(b.FreeCapacity, capacity - expectedSum);
            Assert.Equal(b.UsedCapacity, expectedSum);
        }
    }
}
