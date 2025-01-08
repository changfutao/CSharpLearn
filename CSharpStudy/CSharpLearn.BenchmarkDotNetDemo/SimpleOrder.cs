using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.BenchmarkDotNetDemo
{
    [MemoryDiagnoser(false)]
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class SimpleOrder
    {
        public List<int> list;

        [GlobalSetup]
        public void Setup()
        {
            list = new List<int>()
            {
                3, 12, 5, 18, 8, 10, 5, 7
            };
        }
        [Benchmark(Baseline = true)]
        public List<int> ListSort()
        {
            list.Sort();
            return list;
        }

        [Benchmark]
        public List<int> ListOrderBy()
        {
            return list.OrderBy(a => a).ToList();
        }

        [Benchmark]
        public List<int> ListOrder()
        {
            return list.Order().ToList();
        }
    }
}
