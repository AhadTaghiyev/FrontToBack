using System;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
	public class About
	{
		public int Id { get; set; }
		[Required]
		public string Description { get; set; }
		public string Image { get; set; }
	}
}

