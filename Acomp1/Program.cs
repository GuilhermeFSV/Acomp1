using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Acomp1
{
    [MemoryDiagnoser]
    public class Tests
    {
        [Params(100, 1000, 10000)]
        public int N { get; set; }

        [Benchmark]
        public int TestMax1()
        {
            return (new Max1()).Max(new RandomArray(N).Array, N);
        }

        [Benchmark]
        public int TestMax2()
        {
            return (new Max2()).Max(new RandomArray(N).Array, N);
        }

        [Benchmark]
        public int TestMax3()
        {
            return (new Max3()).Max(new RandomArray(N).Array, N);
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
            Console.Read();
        }
    }
}