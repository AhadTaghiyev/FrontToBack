using System;
using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Context
{
	public class FrontToBackDbContext:DbContext
	{
		public FrontToBackDbContext(DbContextOptions<FrontToBackDbContext> options):base(options)
		{

		}
		public DbSet<Slide> Slides { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Setting> Settings { get; set; }
    }
}

