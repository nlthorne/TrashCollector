using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]

        public int ID { get; set; }
        [Required]
        [Display(Name = "First Name: ")]
        public string First_Name { get; set; }
        [Required]
        [Display(Name = "Last Name: ")]
        public string Last_Name { get; set; }

        [ForeignKey("Route")]
        public int RouteID { get; set; }
        public Route Route { get; set; }
    }
}