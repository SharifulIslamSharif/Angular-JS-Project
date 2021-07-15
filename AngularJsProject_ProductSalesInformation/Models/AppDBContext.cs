using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJsProject_ProductSalesInformation.Models
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<JsProduct> jsProducts { get; set; }
    }
}
