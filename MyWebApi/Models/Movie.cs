using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models
{
	public class Movie
	{
	
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Genre { get; set; }
		public DateTime ReleaseDate { get; set; }
	}

}
