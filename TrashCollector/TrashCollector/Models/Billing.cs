using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Billing
    {
        //public bool HasCreditCard { get; set; }
        public bool HasBillingAddress { get; set; }

        [Key]

        public int ID { get; set; }
        [Display(Name = "Recurring: ")]
        public bool Recurring { get; set; }
        [Display(Name = "Credit Card: ")]
        public int CreditCardID { get; set; }
        [Display(Name = "Due Date")]
        public bool IsBillDue { get; set; }
        public Credit_Card CreditCard { get; set; }
        [Display(Name = "Billing Address: ")]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

    }
    public class AddCreditCard
    {
        [Required]
        [Display(Name = "Add Credit Card")]
        [ForeignKey("CreditCard")]
        public Credit_Card CreditCard { get; set; }
    }
    public class AddOnlineMethod
    {
        [Display(Name = "OnlinePayment")]
        [ForeignKey("OnlinePayment")]
        public Online_Methods OnlineMethods { get; set; }
    }
    public class AddBillingAddress
    {
        [Required]
        [Display(Name = "Address")]
        public Address Address { get; set; }
    }
}