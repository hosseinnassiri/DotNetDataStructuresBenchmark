using System.Collections.Generic;
using FizzWare.NBuilder;

namespace DotNetDataStructures.Benchmarks.Model
{
	public class Repository
	{
		public static IList<Product> GenerateProducts(int size)
		{
			var attributes = GenerateAttributesList(10);
			return Builder<Product>.CreateListOfSize(size)
				.All()
				.With(x => x.Attributes = attributes)
				.Build();
		}

		public static IList<Attribute> GenerateAttributesList(int size)
		{
			return Builder<Attribute>.CreateListOfSize(size)
				.Random(1)
				.With(x => x.Name = "Color")
				.With(x => x.Value = "Red")
				.Random(1)
				.With(x => x.Name = "Price")
				.With(x => x.Value = "100")
				.Build();
		}

		public static IList<string> GenerateProductCodes(int size)
		{
			var productCodes = new List<string>(size);
			for (int i = 1; i <= size; i++)
			{
				productCodes.Add($"Code{i}");
			}

			return productCodes;
		}
	}
}