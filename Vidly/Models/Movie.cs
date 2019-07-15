using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Released { get; set; }
		public DateTime Added { get; set; }		
		public uint Stock { get; set; }
		[Required]
		public Genre Genre { get; set; }
	}
}