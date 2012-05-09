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
                new Product{Id=1, ProductName="Carrots", Description="Make you see in the dark", Price=1.99M, Quantity=100},
                new Product{Id=2, ProductName="Cabbage", Description="Yummy", Price=.50M, Quantity=23},
                new Product{Id=3, ProductName="Sprouts", Description="Yuck!", Price=.75M, Quantity=71},
                new Product{Id=4, ProductName="Peas", Description="Small and round", Price=.20M, Quantity=3},
                new Product{Id=5, ProductName="Apples", Description="Tasty", Price=1.30M, Quantity=1},
                new Product{Id=6, ProductName="Pears", Description="Fruity", Price=.70M, Quantity=101},
                new Product{Id=7, ProductName="Pinapple", Description="Nom Nom", Price=.50M, Quantity=73},
                new Product{Id=8, ProductName="zCarrots", Description="Make you see in the dark", Price=1.99M, Quantity=100},
                new Product{Id=9, ProductName="zCabbage", Description="Yummy", Price=.50M, Quantity=23},
                new Product{Id=10, ProductName="zSprouts", Description="Yuck!", Price=.75M, Quantity=71},
                new Product{Id=11, ProductName="zPeas", Description="Small and round", Price=.20M, Quantity=3},
                new Product{Id=12, ProductName="zApples", Description="Tasty", Price=1.30M, Quantity=1},
                new Product{Id=13, ProductName="zPears", Description="Fruity", Price=.70M, Quantity=101},
                new Product{Id=14, ProductName="zPinapple", Description="Nom Nom", Price=.50M, Quantity=73},
            };
            return products.AsQueryable<Product>();
        }

    }
}
