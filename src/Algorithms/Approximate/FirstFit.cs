using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCutter.Algorithms.Abstract;
using StockCutter.Model;
using StockCutter.Model.Interfaces;

namespace StockCutter.Algorithms.Approximate
{
    public class FirstFit<T> : Algorithm<T> where T : IBin, new()
    {
        private List<T> bins = new List<T>();

        public FirstFit(Problem<T> prob) : base(prob)
        {
        }

        public override IEnumerable<IEnumerable<IBin>> GetSolutions()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<T> Solve()
        {
            var sortedItems = this.prob.Items.OrderByDescending(i => i.Size);

            foreach(IPackable i in sortedItems)
            {
                // Put item into first bin in which it fits
                bool added = false;
                foreach(T bin in bins)
                {
                    if(bin.FreeCapacity >= i.Size)
                    {
                        bin.Add(i);
                        added = true;
                    }
                }

                // If item didn't fit into any bin, create new bin for it
                if(!added)
                {
                    this.bins.Add(new T());
                    this.bins.Last().Add(i);
                }
            }

            return bins;
        }
    }
}
