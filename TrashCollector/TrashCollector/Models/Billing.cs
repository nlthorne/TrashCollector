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
        [Key]

        public int ID { get; set; }
        [Display(Name = "Recurring")]
        public bool Recurring { get; set; }

        [ForeignKey("CreditCard")]
        public int Credit_CardID { get; set; }
        public Credit_Card CreditCard { get; set; }

        [ForeignKey("OnlineMethods")]
        public int Online_MethodsID { get; set; }
        public Online_Methods OnlineMethods { get; set; }
    }
}