using AngularJsProject_ProductSalesInformation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AngularJsProject_ProductSalesInformation.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _db;

        public ProductController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult AllProducts()
        {
            var data = _db.jsProducts.ToList();
            return Json(data, new JsonSerializerOptions());
        }

        public JsonResult AddProduct([FromBody] JsProduct product)
        {
            _db.jsProducts.Add(product);
            _db.SaveChanges();
            var data = _db.jsProducts.ToList();
            return Json(data, new JsonSerializerOptions());
        }

        public JsonResult UpdateProduct([FromBody] JsProduct product)
        {
            var upProduct = _db.jsProducts.FirstOrDefault(p => p.JsProductId == product.JsProductId);
            upProduct.SalesDate = product.SalesDate;
            upProduct.Name = product.Name;
            upProduct.Brand = product.Brand;
            upProduct.Quantity = product.Quantity;
            upProduct.Price = product.Price;
            _db.Entry(upProduct).State = EntityState.Modified;
            _db.SaveChanges();
            var data = _db.jsProducts.ToList();
            return Json(data, new JsonSerializerOptions());
        }
         
        public string DeleteProduct(int? JsProductId)
        {
            var data = _db.jsProducts.Where(e => e.JsProductId == JsProductId).Select(p => p).FirstOrDefault();
            if (data != null)
            {
                _db.jsProducts.Remove(data);
            }
            _db.SaveChanges();
            return "Data deleted successfully";
        }
    }
}
