using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductLocations_Draft11_Full.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductLocations_Draft11_Full.Controllers {
    public class DataController : Controller {
        // GET: /<controller>/
        public IActionResult Index() {
            var model = GetData();
            ViewData["EntryId"] = model.EntryId;
            ViewData["ElementId"] = model.ElementId;
            ViewData["DateAdded"] = model.DateAdded;
            ViewData["Message"] = "This is a message";
            return View();
        }
        // Creating a table cell of data to test
        public TableCell GetData() {
            var cell = new TableCell() {
                EntryId = 0,
                ElementId = "0",
                DateAdded = DateTime.Now
            };
            return cell;
        }
    }
}
