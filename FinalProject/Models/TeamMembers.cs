using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class TeamMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; } = string.Empty;

        public DateTime Birthdate { get; set; }

        public string CollegeProgram { get; set; } = string.Empty;

        public string YearInProgram { get; set; } = string.Empty;
    }
}
