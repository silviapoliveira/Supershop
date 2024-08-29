using System.ComponentModel.DataAnnotations;
using System;

namespace Supershop.Models
{
    public class DeliveryViewModel
    {
        public int Id { get; set; }


        [Display(Name = "Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }
    }
}
