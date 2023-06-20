using System;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
	public class Setting
	{
        public int Id { get; set; }
		[Required]
		public string Location { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        [Required]
        public string Email { get; set; }
    }
}

