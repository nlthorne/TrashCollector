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

        //[ForeignKey("Address")]
        //public int PickupAddressID { get; set; }
        //public virtual Address Address { get; set; }
    }
}