﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Country
    {
        [Key]

        public int ID { get; set; }
        [Display(Name = "Country: ")]
        public string Name { get; set; }
    }
}