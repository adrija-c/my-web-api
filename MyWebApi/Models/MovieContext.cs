using Microsoft.EntityFrameworkCore;
using System;

namespace MyWebApi.Models
{
	public class MovieContext : DbContext
	{
		public MovieContext(DbContextOptions<MovieContext> options)
			: base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; } = null!;

		// Add data seeding
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Seed initial data into the Movies table
			modelBuilder.Entity<Movie>().HasData(
				new Movie
				{
					Id = 1003,
					Title = "Inception",
					Genre = "Sci-Fi",
					ReleaseDate = new DateTime(2010, 7, 16)
				},
				new Movie
				{
					Id = 1004,
					Title = "The Dark Knight",
					Genre = "Action",
					ReleaseDate = new DateTime(2008, 7, 18)
				},
				new Movie
				{
					Id = 1005,
					Title = "Interstellar",
					Genre = "Sci-Fi",
					ReleaseDate = new DateTime(2014, 11, 7)
				}
			);
		}
	}
}
