using System;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
	public class Slide
	{
		public  int Id { get; set; }
		[Required]
		[StringLength(60)]
		public string Title { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        public string Link { get; set; }
	}
}

