using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Supershop.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(50, ErrorMessage = "The field {0} can only contain {1} charaters.")]
        public string FirstName { get; set; }


        [MaxLength(50, ErrorMessage = "The field {0} can only contain {1} charaters.")]
        public string LastName { get; set; }


        [MaxLength(128, ErrorMessage = "The field {0} can only contain {1} charaters.")]
        public string Address { get; set; }


        public int CityId { get; set; }


        public City City { get; set; }


        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";
    }
}
