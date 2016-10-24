using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class PickupAddress
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Pickup Address?")]
        public bool IsPickupAddress { get; set; }
    }
}