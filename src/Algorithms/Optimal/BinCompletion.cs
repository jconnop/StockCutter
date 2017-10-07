using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCutter.Algorithms.Abstract;
using StockCutter.Model;
using StockCutter.Model.Interfaces;

namespace StockCutter.Algorithms.Optimal
{
    public class BinCompletion : Algorithm
    {
        public BinCompletion(Problem prob) : base(prob)
        {
        }

        public override IEnumerable<IEnumerable<IBin>> GetSolutions()
        {
            throw new NotImplementedException();
        }
    }
}
