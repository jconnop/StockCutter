using StockCutter.Model.Interfaces;

namespace StockCutter.Model
{
    public class Item : IPackable
    {
        public int Size
        {
            get;
        }

        public Item(int size)
        {
            this.Size = size;
        }
    }
}
