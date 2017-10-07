using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCutter.Model.Interfaces;

namespace StockCutter.Model
{
    public class Problem<T> where T : IBin
    {
        public List<IPackable> Items
        {
            get;
        }

        public Problem()
        {
            this.Items = new List<IPackable>();
        }

        public Problem(IEnumerable<IPackable> items)
        {
            this.Items = items.ToList();
        }
    }
}
