using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductLocations_Draft2_Empty.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductLocations_Draft2_Empty.Controllers {
    public class HomeController : Controller {
        // GET: /<controller>/
        public IActionResult Index() {
            var model = new TableCell() {
                Id = 5,
                ElementName = "Product0",
                ServerName = "ECN-West1",
                ColumnNumber = "1",
                TableNumber = "0",
                ProductName = "Product Name",
                DateAdded = DateTime.Now
            };
            return Hey(model);
        }

        [Route("~/index.html")]
        private IActionResult Hey(TableCell model2) {
            return Content("Hey");
        }
    }
}
