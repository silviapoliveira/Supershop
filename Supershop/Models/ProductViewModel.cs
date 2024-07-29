using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Supershop.Data.Entities;

namespace Supershop.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name="Image")]
        public IFormFile ImageFile { get; set; }
    }
}
