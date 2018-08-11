using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using DotNetDataStructures.Benchmarks.Tests;

namespace DotNetDataStructures.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
			var summary1 = BenchmarkRunner.Run<UpdateAllProductsPerformanceTests>(
				ManualConfig
					.Create(DefaultConfig.Instance).With(MemoryDiagnoser.Default));
		}
	}
}
