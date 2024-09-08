using System.ComponentModel.DataAnnotations;

namespace Supershop.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
