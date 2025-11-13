using System.ComponentModel.DataAnnotations;

namespace Institute_Of_Fine_Arts.Models
{
    public class Exhibition
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ExhibitionDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string? Status { get; set; }

        public string? Banner { get; set; }

        public ICollection<ExhibitedPainting>? ExhibitedPaintings { get; set; }
    }
}
