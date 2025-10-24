using System.ComponentModel.DataAnnotations;

namespace ReactBackendExample.Models.DTOs.Genre
{
    public class GenreCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
