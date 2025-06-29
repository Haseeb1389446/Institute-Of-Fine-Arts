﻿using System.ComponentModel.DataAnnotations;

namespace Institute_Of_Fine_Arts.Models
{
    public class Competition
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Conditions { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string? AwardDetails { get; set; }

        public string? Banner { get; set; }
    }
}
