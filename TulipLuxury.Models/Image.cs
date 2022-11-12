using System;
using System.ComponentModel.DataAnnotations;

namespace TulipLuxury.Models
{
	public class Image
	{
        [Required]
        public string Id { get; set; }

        [Required]
        public string CarId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool IsFeature { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

