using System.ComponentModel.DataAnnotations;

namespace Institute_Of_Fine_Arts.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public string? Action { get; set; }

        public string? Description { get; set; }

        public string? Icon { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
