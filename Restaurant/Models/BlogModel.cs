﻿using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class BlogModel
    {
        [Key]
        public long id { get; set; }

        [Required, MaxLength(255)]
        public string title { get; set; }

        [Required]
        public string content { get; set; }

        [MaxLength(10)]
        public string status { get; set; } = "ACTIVE";
        public DateTime? createdDate { get; set; } = DateTime.Now;

        public DateTime? updatedDate { get; set; }

        public string createdBy { get; set; }

        public string updatedBy { get; set; }

        public string banner { get; set; }
    }
}
