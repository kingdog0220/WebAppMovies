using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string? Title { get; set; } = null;

        public DateOnly ReleaseDate { get; set; }

        public string? Genre { get; set; } = null;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
