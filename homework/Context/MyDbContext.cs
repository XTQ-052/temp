using homework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Context
{
	public class MyDbContext : DbContext
	{
		//

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-DNH8G00;Initial Catalog=homework;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<Author> authors { get; set; }
		public DbSet<Book> books { get; set; }
		public DbSet<BookType> bookTypes { get; set; }
		public DbSet<Student> students { get; set; }
	}
}
