using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class CustomerAccount
    {
        public string BillingAddress { get; set; }
        public string CustomerName { get; set; }
        public DateTime PickupSchedule { get; set; }
        public bool OnVacation { get; set; }
    }
    public class AddBillingMethod
    {
        [Required]
        [Display(Name = "AddBilling")]
        public Billing AddBilling { get; set; }
    }
    public class ChangeBillingMethod
    {
        [Required]
        [Display(Name = "ChangeBilling")]
        public Billing ChangeBilling { get; set; }
    }
    public class RemoveBillingMethod
    {
        [Required]
        [Display(Name = "RemoveBilling")]
        public Billing RemoveBilling { get; set; }
    }
    public class CustomerInformation
    {
        [Required]
        [Display(Name = "Customer")]
        public Customer Customer { get; set; }
    }
    public class GetPickupSchedule
    {
        [Required]
        [Display(Name = "PickupDate")]
        public Pickup_Times PickupDate { get; set; }
    }
}