using System;
using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Slide> Slides { get; set; }
		public About About { get; set; }
	}
}

