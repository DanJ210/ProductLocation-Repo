using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLocations_Draft2_Empty.Models {
    public class TableCell {
        public int Id { get; set; }
        public string ElementName { get; set; }
        public string ServerName { get; set; }
        public DateTime DateAdded { get; set; }
        public string TableNumber { get; set; }
        public string ColumnNumber { get; set; }
        public string ProductName { get; set; }
    }
}
