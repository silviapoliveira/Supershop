﻿using System.ComponentModel.DataAnnotations;

namespace Supershop.Models
{
    public class CityViewModel
    {
        public int CountryId { get; set; }


        public int CityId { get; set; }


        [Required]
        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} characters.")]
        public string Name { get; set; }
    }
}
