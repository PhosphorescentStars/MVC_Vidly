using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
	public class Genre
	{
		public short Id { get; set; }
		[Required]
		[StringLength(100)]
		public string Description { get; set; }
	}
}