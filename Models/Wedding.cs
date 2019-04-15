using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage="Name must be 3 characters or longer!")]
        public string WedderOne { get; set; }
        [Required]
        [MinLength(3, ErrorMessage="Name must be 3 characters or longer!")]
        public string WedderTwo { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MinLength(3, ErrorMessage="Address must be 3 characters or longer!")]
        public string WeddingAddress{get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public int UserId { get; set; }

        public List<Association> Guests { get; set; }

    }
}