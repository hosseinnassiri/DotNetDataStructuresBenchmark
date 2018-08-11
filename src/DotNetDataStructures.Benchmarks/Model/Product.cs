using System.Collections.Generic;

namespace DotNetDataStructures.Benchmarks.Model
{
    public class Product
    {
	    public string Name { get; set; }
		public string Code { get; set; }
		public bool Flag { get; set; }
		public IList<Attribute> Attributes { get; set; }
	}

	public class Attribute
	{
		public string Name { get; set; }
		public string Value { get; set; }
	}
}