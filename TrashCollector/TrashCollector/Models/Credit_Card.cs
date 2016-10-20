using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Credit_Card
    {
        [Key]
        
        public int ID { get; set; }
        [Display(Name = "Credit card provider: ")]
        public string Provider { get; set; }
        [Display(Name = "Name on card: ")]
        public string Full_Name { get; set; }
        [Display(Name = "Card number: ")]
        public int Number { get; set; }
        [Display(Name = "Expiration Date: ")]
        public int Exp_Date { get; set; }
        [Display(Name = "CVC code on back of card: ")]
        public int CVC { get; set; }

        [ForeignKey("BillingAddress")]
        public int BillingAddressID { get; set; }
        public BillingAddress BillingAddress { get; set; }
    }
}