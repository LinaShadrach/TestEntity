using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lina2.Models
{
	[Table("Products")]
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Source { get; set; }
		public string Season { get; set; }
		public string Method { get; set; }
		public string Size { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public decimal Cost { get; set; }
	}
}
