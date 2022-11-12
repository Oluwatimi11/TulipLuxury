using System;
using System.ComponentModel.DataAnnotations;

namespace TulipLuxury.Models
{
	public class Rating
	{
        [Required]
        public string Id { get; set; }

        [Required]
        public string CarId { get; set; }

        public string Ratings { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

