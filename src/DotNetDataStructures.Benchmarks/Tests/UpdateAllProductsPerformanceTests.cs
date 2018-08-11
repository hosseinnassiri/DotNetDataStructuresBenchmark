using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using DotNetDataStructures.Benchmarks.Model;

namespace DotNetDataStructures.Benchmarks.Tests
{
	[MemoryDiagnoser]
	[SimpleJob(RunStrategy.ColdStart, launchCount: 1)]
	public class UpdateAllProductsPerformanceTests
    {
	    private IList<Product> _products;
	    private IDictionary<string, Product> _productsDictionary;
	    private IList<string> _productCodes;
	    private ProductService _service;

		[GlobalSetup]
	    public void GlobalSetup()
	    {
		    var size = 10000;
		    _products = Repository.GenerateProducts(size);
		    _productsDictionary = _products.ToDictionary(x => x.Code);
		    _productCodes = Repository.GenerateProductCodes(size / 2);

		    _service = new ProductService();
	    }

	    [Benchmark]
	    public IList<string> UpdateAllProductsUsingLinq() =>
		    _service.UpdateAllProductsUsingLinq(_products, _productCodes);

	    [Benchmark]
	    public IList<string> UpdateAllProductsUsingDictionary() =>
		    _service.UpdateAllProductsUsingDictionary(_productsDictionary, _productCodes);

	}
}