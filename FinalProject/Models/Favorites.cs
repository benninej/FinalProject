using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Favorites
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public string Food { get; set; } = string.Empty;
        public string Music { get; set; } = string.Empty;
        public string Hobby { get; set; } = string.Empty;
        public string Animal { get; set; } = string.Empty;
    }
}