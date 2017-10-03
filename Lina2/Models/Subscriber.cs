using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lina2.Models
{
	[Table("Subscribers")]
	public class Subscriber
	{
		[Key]
		public int SubscriberId { get; set; }
		[Required(ErrorMessage = "Email address is required.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Name is required.")]
		public string Name { get; set; }
		[DataType(DataType.Date)]
		public string Birthday { get; set; }
		public int Zip { get; set; }

	}
}
