using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace InfiniateScroll.Controllers
{
    public class ProductApiController : ApiController
    {

        public class Product
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string Description { get; set; }
        }

        public IQueryable<Product> Get()
        {
            System.Threading.Thread.Sleep(500);
            var products = new List<Product>
            {
                new Product{Id=4, ProductName="Peas", Price=.20M},
                new Product{Id=5, ProductName="Apples", Price=1.30M},
                new Product{Id=6, ProductName="Pears", Price=.70M},
                new Product{Id=7, ProductName="Pinapple", Price=.50M,},
                new Product{Id=7, ProductName="Canary", Price=.20M},
                new Product{Id=8, ProductName="Cantaloupe", Price=.20M},
                new Product{Id=9, ProductName="Casaba", Price=.20M},
                new Product{Id=10, ProductName="Crenshaw", Price=.20M},
                new Product{Id=11, ProductName="Galia", Price=.20M},
                new Product{Id=12, ProductName="Honeydew", Price=.20M},
                new Product{Id=13, ProductName="Persian", Price=.20M},
                new Product{Id=14, ProductName="Santa Claus", Price=.20M},
                new Product{Id=15, ProductName="Sharlyn", Price=.20M},
                new Product{Id=16, ProductName="Watermelon", Price=.20M},
                new Product{Id=17, ProductName="Blackberry", Price=.20M},
                new Product{Id=18, ProductName="Raspberry", Price=.20M},
                new Product{Id=19, ProductName="Mulberry", Price=.20M},
                new Product{Id=20, ProductName="Strawberry", Price=.20M},
                new Product{Id=21, ProductName="Cranberry", Price=.20M},
                new Product{Id=22, ProductName="Blueberry", Price=.20M},
                new Product{Id=23, ProductName="Jostaberry", Price=.20M},
                new Product{Id=24, ProductName="Gooseberry", Price=.20M},
                new Product{Id=25, ProductName="Elderberry", Price=.20M},
                new Product{Id=26, ProductName="Currant", Price=.20M},
                new Product{Id=27, ProductName="Grapes", Price=.20M},
                new Product{Id=28, ProductName="Kiwi Fruit", Price=.20M},
                new Product{Id=29, ProductName="Papaya", Price=.20M},
                new Product{Id=30, ProductName="Mango", Price=.20M},
                new Product{Id=31, ProductName="Figs", Price=.20M},
                new Product{Id=32, ProductName="Dates", Price=.20M},
                new Product{Id=33, ProductName="Olives", Price=.20M},
                new Product{Id=34, ProductName="Jujubes", Price=.20M},
                new Product{Id=35, ProductName="Pomegranates", Price=.20M},
                new Product{Id=36, ProductName="Lemons", Price=.20M},
                new Product{Id=37, ProductName="Limes", Price=.20M},
                new Product{Id=38, ProductName="Key Limes", Price=.20M},
                new Product{Id=39, ProductName="Mandarin", Price=.20M},
                new Product{Id=40, ProductName="Orange", Price=.20M},
                new Product{Id=41, ProductName="Sweet Lime", Price=.20M},
                new Product{Id=42, ProductName="Tangerine", Price=.20M},
                new Product{Id=43, ProductName="Clementines", Price=.20M},
                new Product{Id=44, ProductName="Grapefruit", Price=.20M},
                new Product{Id=45, ProductName="Satsumas", Price=.20M},
                new Product{Id=46, ProductName="Tangelos", Price=.20M},
                new Product{Id=47, ProductName="Uglis", Price=.20M},
                new Product{Id=48, ProductName="Pommelo", Price=.20M},
                new Product{Id=49, ProductName="Quinces", Price=.20M},
                new Product{Id=50, ProductName="Prickly Pear", Price=.20M},
                new Product{Id=51, ProductName="Kumquats", Price=.20M},
                new Product{Id=52, ProductName="Minneolas", Price=.20M},
            };
            return products.AsQueryable<Product>();
        }

    }
}
