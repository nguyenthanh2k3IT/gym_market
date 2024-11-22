﻿using System.ComponentModel.DataAnnotations;

namespace GymMarket.API.DTOs.CourseOption
{
    public class CourseOptionUpdateDTO
    {
        [Required(ErrorMessage = "OptionName is required.")]
        [StringLength(100, ErrorMessage = "OptionName cannot exceed 100 characters.")]
        public string? OptionName { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative value.")]
        public decimal? Price { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
