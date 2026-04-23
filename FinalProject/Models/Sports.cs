using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Sports
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Sport { get; set; }
        public string Team { get; set; }
        public string Wins { get; set; }
    }
}
