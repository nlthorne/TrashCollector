using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Pickup_Times
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Pickup Day")]
        public DateTime Day { get; set; }
        [Display(Name ="On Vacation")]
        public bool Vacation { get; set; }
        [Display(Name = "Vacation Start Date: ")]
        public DateTime VacationStart { get; set; }
        [Display(Name = "Vacation End Date: ")]
        public DateTime VacationEnd { get; set; }
        [Display(Name = "Pickup Every Week?")]
        public bool EveryWeek { get; set; }
        [Display(Name = "Pickup Every Other Week?")]
        public bool EveryOtherWeek { get; set; }
    }
}