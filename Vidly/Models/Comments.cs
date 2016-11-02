using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string User { get; set; }
        [Required]
        public string Comment { get; set; }
        public Movies Movies { get; set; }
        public int MoviesId { get; set; }

    }
}