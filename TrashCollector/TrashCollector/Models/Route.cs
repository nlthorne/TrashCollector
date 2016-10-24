using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Route
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Route Name: ")]
        public string Name { get; set; }

        //[ForeignKey("PickupTimes")]
        //public int Pickup_TimesID { get; set; }
        //public Pickup_Times PickupTimes { get; set; }

        //[ForeignKey("Address")]
        //public int Pickup_AddressID { get;}
        //public Address Address { get; }
    }
}