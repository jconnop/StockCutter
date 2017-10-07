namespace StockCutter.Model.Interfaces
{
    public interface IBin
    {
        int Capacity
        {
            get;
        }

        int UsedCapacity
        {
            get;
        }

        int FreeCapacity
        {
            get;
        }

        void Add(IPackable item);
        void Remove(IPackable item);
    }
}
