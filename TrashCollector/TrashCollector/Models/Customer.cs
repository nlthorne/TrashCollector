using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "First Name: ")]
        public string First_Name { get; set; }
        [Display(Name = "Last Name: ")]
        public string Last_Name { get; set; }
        [Display(Name = "Contact Number: ")]
        public int Contact_Number { get; set; }
        [Display(Name = "Email Address: ")]
        public string Email { get; set; }

        //[ForeignKey("PickupAddress")]
        //public int PickupAddressID { get; set; }
        //public PickupAddress PickupAddress { get; set; }

        //[ForeignKey("PickupTimes")]
        //public int Pickup_TimesID { get; set; }
        //public Pickup_Times PickupTimes { get; set; }

        //[ForeignKey("Billing")]
        //public int BillingID { get; set; }
        //public Billing Billing { get; set; }
    }
}