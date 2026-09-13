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
        public string? StudentId { get; set; }

        [Required]
        public string? PaintingName { get; set; }

        public string? Description { get; set; }

        public string? PoemOrQuote { get; set; }

        public int CompetitionId { get; set; }

        public int AwardId { get; set; }

        public string? PaintingImage { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;

        [ForeignKey("CompetitionId")]
        public Competition? Competition { get; set; }

        [ForeignKey("StudentId")]
        public IdentityUser? Student { get; set; }

        [ForeignKey("AwardId")]
        public Award? Award { get; set; }
    }
}
