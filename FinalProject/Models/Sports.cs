using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Sports
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Team { get; set; }
        public string Wins { get; set; }
    }
}
