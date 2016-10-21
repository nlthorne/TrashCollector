using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class BillingAddress
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Billing Address?")]
        public bool IsBillingAddress { get; set; }
    }
}