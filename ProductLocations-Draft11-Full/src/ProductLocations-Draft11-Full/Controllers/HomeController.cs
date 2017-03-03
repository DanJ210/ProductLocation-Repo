using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductLocations_Draft11_Full.Models;

namespace ProductLocations_Draft11_Full.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            var model = new TableCell() {
                EntryId = 0,
                ElementId = "0",
                DateAdded = DateTime.Now
            };
            return View("here is some text" + model);
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
