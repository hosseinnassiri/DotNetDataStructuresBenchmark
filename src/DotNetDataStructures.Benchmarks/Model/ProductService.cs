using System.Linq;
using System.Collections.Generic;

namespace DotNetDataStructures.Benchmarks.Model
{
	public class ProductService
	{
		public IList<string> UpdateAllProductsUsingLinq(IList<Product> products, IList<string> productCodes)
		{
			var result = new List<string>();
			foreach (var code in productCodes)
			{
				var product = products.FirstOrDefault(x => x.Code == code);
				if (product != null)
				{
					product.Flag = true;
					result.Add(code);
				}
			}

			return result;
		}

		public IList<string> UpdateAllProductsUsingDictionary(IDictionary<string, Product> products, IList<string> productCodes)
		{
			var result = new List<string>();
			foreach (var code in productCodes)
			{
				if (products.ContainsKey(code))
				{
					products[code].Flag = true;
					result.Add(code);
				}
			}

			return result;
		}
	}
}