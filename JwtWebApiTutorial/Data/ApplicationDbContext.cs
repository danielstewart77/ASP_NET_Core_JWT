using JwtWebApiTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtWebApiTutorial.Data
{
	public class Db : DbContext
	{
		public DbSet<User> Users { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var config = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.Build();

			options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
		}
	}
}
