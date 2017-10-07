using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCutter.Model;
using StockCutter.Model.Interfaces;

namespace StockCutter.Algorithms.Abstract
{
    public abstract class Algorithm<T> where T : IBin
    {
        protected Problem<T> prob;
        
        public Algorithm(Problem<T> prob)
        {
            this.prob = prob;
        }

        public abstract IEnumerable<IEnumerable<IBin>> GetSolutions();

        public IEnumerable<IBin> GetFirstSolution()
        {
            return this.GetSolutions().First();
        }
    }
}
