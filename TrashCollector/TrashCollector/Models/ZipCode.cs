using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class ZipCode
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Zipcode: ")]
        public int Number { get; set; }
    }
}