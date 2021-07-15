using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJsProject_ProductSalesInformation.Models
{
    public class JsProduct
    {
        public int JsProductId { get; set; }
        public DateTime SalesDate { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Brand Is Required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Quantity Is Required")]
        public string Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
