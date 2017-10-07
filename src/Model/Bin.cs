using System;
using System.Collections.Generic;
using StockCutter.Model.Interfaces;

namespace StockCutter.Model
{
    public class Bin : IBin
    {
        private List<IPackable> Items = new List<IPackable>();
        private int usedCapacity;
        private int freeCapacity;

        public int Capacity
        {
            get;
        }

        public int UsedCapacity
        {
            get
            {
                return usedCapacity;
            }
        }

        public int FreeCapacity
        {
            get
            {
                return freeCapacity;
            }
        }

        public Bin(int capacity)
        {
            this.Items = new List<IPackable>();
            this.Capacity = capacity;
            this.freeCapacity = capacity;
            this.usedCapacity = 0;
        }

        public void Add(IPackable item)
        {
            this.Items.Add(item);
            this.usedCapacity += item.Size;
            this.freeCapacity -= item.Size;
        }

        public void Remove(IPackable item)
        {
            this.Items.Remove(item);
            this.usedCapacity -= item.Size;
            this.freeCapacity += item.Size;
        }
    }
}
