using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public interface IProductDB
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
    }

    public static class ProductFactory
    {
        public static IProductDB GetComponent() => new ProductDB();
    }
    class ProductDB : IProductDB
    {
        static ProductEntities context = new ProductEntities();
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var found = context.Products.First((p) => p.ProductId == id);
            context.Products.Remove(found);
            context.SaveChanges();
        }

        public List<Product> GetAllProducts() => context.Products.ToList();

        public void UpdateProduct(Product product)
        {
            var found = context.Products.First((p) => p.ProductId == product.ProductId);
            found.ProductImage = product.ProductImage;
            found.ProductName = product.ProductName;
            found.ProductPrice = product.ProductPrice;
            found.Quantity = product.Quantity;
            context.SaveChanges();
        }
    }
}
