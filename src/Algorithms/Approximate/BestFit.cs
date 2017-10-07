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
    public class BestFit : Algorithm
    {
        public BestFit(Problem prob) : base(prob)
        {
            // todo: not generic types lol
        }

        public override IEnumerable<IEnumerable<IBin>> GetSolutions()
        {
            throw new NotImplementedException();
        }
    }
}
