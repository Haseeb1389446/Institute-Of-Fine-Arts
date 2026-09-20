using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Of_Fine_Arts.Models
{
    public class Painting
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? PaintingName { get; set; }

        public string? Description { get; set; }

        public string? PoemOrQuote { get; set; }


        public string? PaintingImage { get; set; }

        public string? Creativity { get; set; }

        public string? Remarks { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int CompetitionId { get; set; }

        [ForeignKey("CompetitionId")]
        public Competition? Competition { get; set; }

        [Required]
        public string? StudentId { get; set; }

        [ForeignKey("StudentId")]
        public IdentityUser? Student { get; set; }
    }
}
