using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }//Url of the image
        public int Price { get; set; }
        public int Quantity { get; set; } = 1;
    }

    public static class ProductRepo
    {
        private static List<Product> _repo = new List<Product>();

        static ProductRepo()
        {
            getAll();
        }
        public static List<Product> AllProducts => _repo;

        private static void getAll()
        {
            _repo.Add(new Product
            {
                ProductId = 1, Image= @".\Images\iphone14.jfif", Price = 500, ProductName = "IPhone"
            });
            _repo.Add(new Product
            {
                ProductId = 2,
                Image = @".\Images\Merc.jfif",
                Price = 75000,
                ProductName = "Mercedes Benz"
            });
            _repo.Add(new Product
            {
                ProductId = 3,
                Image = @".\Images\dellXps.jfif",
                Price = 1500,
                ProductName = "DEll XPS"
            });
            _repo.Add(new Product
            {
                ProductId = 4,
                Image = @".\Images\iMac.jfif",
                Price = 2200,
                ProductName = "I Mac 2"
            });
        }

        public static void UpdateProduct(Product product)
        {
            var found = _repo.Find((p) => p.ProductId == product.ProductId);
            found.ProductName = product.ProductName;
            found.Price = product.Price;
        }

        public static void DeleteProduct(int id)
        {
            var found = _repo.Find((p) => p.ProductId == id);
            _repo.Remove(found);
        }

        internal static void AddNewProduct(Product product) => _repo.Add(product);
    }
}