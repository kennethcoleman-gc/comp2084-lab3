using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        List<Phone> PhoneList = new List<Phone>
        {
            new Phone {PhoneID = 1, PhoneName = "S10", Manufacturer = "Samsung", Msrp = 500.00, ScreenSize = "6\"", DateReleased = DateTime.Parse("2019-01-01")},
            new Phone {PhoneID = 2, PhoneName = "iPhone 11", Manufacturer = "Apple", Msrp = 1000.00, ScreenSize = "6.5\"", DateReleased = DateTime.Parse("2019-12-02")},
            new Phone {PhoneID = 2, PhoneName = "Pixel", Manufacturer = "Google", Msrp = 1200.00, ScreenSize = "7\"", DateReleased = DateTime.Parse("2018-11-15")}
        };

        // GET: Phone
        public ActionResult Index()
        {
            return View(PhoneList);
        }
    }
}