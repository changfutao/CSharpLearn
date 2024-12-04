using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace CSharpLearn.BenchmarkDotNetDemo
{
    [SimpleJob(RuntimeMoniker.Net80)] // 使用.net8
    [MemoryDiagnoser(false)]
    [RankColumn]
    [Orderer]
    
    public class SimpleDemo
    {
        [Params(4, 16, 130)] // 三种参数情况
        public int count; // 这里既支持字段也支持属性
        public List<int> list;

        [GlobalSetup]
        public void Init()
        {
            
        }

        [Benchmark(Baseline = true)] // 测试
        public List<int> ListInit()
        {
            list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            return list;
        }

        [Benchmark] // 测试
        public List<int> ListInitCount()
        {
            list = new List<int>(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(i);
            }
            return list;
        }

        [Benchmark]
        public List<int> ListInitLinq()
        {
            return Enumerable.Range(0, count).ToList();
        }

    }
}
