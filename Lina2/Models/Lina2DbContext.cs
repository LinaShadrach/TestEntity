using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lina2.Models
{
    public class Lina2DbContext : DbContext
	{
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Subscriber> Subscribers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL(@"server=localhost;user id=root;password=root;port=3306;database=todo;");
		}
		public Lina2DbContext(DbContextOptions<Lina2DbContext> options) : base(options)
		{
		}
		public Lina2DbContext() { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}