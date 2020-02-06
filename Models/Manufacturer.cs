﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime DateReleased { get; set; }
        public List<Phone> PhoneList { get; set; }
        public Manufacturer()
        {
            ManufacturerName = "";
            URL = "";
            DateReleased = DateTime.Parse("2020-01-01");
        }
    }
}