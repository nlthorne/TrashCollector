using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Street Number: ")]
        public int Number { get; set; }
        [Display(Name = "Street Name: ")]
        public string Street_Name { get; set; }


        [ForeignKey("City")]
        public int CityID { get; set; }
        public City City { get; set; }

        [ForeignKey("State")]
        public int StateID { get; set; }
        public State State { get; set; }

        [ForeignKey("ZipCode")]
        public int ZipCodeID { get; set; }
        public ZipCode ZipCode { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public Country Country { get; set; }

        [ForeignKey("PickupAddress")]
        public int PickupAddressID { get; set; }
        public virtual PickupAddress PickupAddress { get; set; }

        [ForeignKey("BillingAddress")]
        public int BillingAddressID { get; set; }
        public virtual BillingAddress BillingAddress { get; set; }

        [ForeignKey("UserID")]
        public ApplicationUser UserID;
    }
}