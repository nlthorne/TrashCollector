using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Online_Methods
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Online Provider: ")]
        public string Provider { get; set; }
        [Display(Name = "Login Name: ")]
        public string Login { get; set; }
    }
}