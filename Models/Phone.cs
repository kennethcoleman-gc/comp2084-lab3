using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneApplication.Models
{
    public class Phone {
        [Key]
        public int PhoneID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string PhoneName { get; set; }
        public double Msrp { get; set; }
        public string ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
        public Phone()
        {
            PhoneName = "";
            
            ScreenSize = "";
            DateReleased = DateTime.Parse("2020-01-01");
        }
    }
}