using SampleRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleRestApi.Controllers
{
    [EnableCors("*", "*", "*", "*")]
    public class ProductController : ApiController
    {
        public List<Product> GetAllProducts()
        {
            var context = new ProductEntites();
            return context.Products.ToList();
        }

        public Product GetProduct(string id)
        {
            var pId = int.Parse(id);
            var context = new ProductEntites();
            return context.Products.FirstOrDefault(p => p.ProductId == pId);
        }

        [HttpPost]//To Add the record
        public Product AddNewProduct(Product product)
        {
            try
            {
                var context = new ProductEntites();
                context.Products.Add(product);
                context.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPut]
        public  void UpdateProduct(Product product)
        {
            var context = new ProductEntites();
            var foundProduct = context.Products.Find(product.ProductId);
            if (foundProduct == null)
                throw new Exception("Product not found");
            foundProduct.ProductImage = product.ProductImage;
            foundProduct.ProductName = product.ProductName;
            foundProduct.ProductPrice = product.ProductPrice;
            foundProduct.Quantity = product.Quantity;
            context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteProduct(string id)
        {
            var pId = int.Parse(id);
            var context = new ProductEntites();
            var found = context.Products.Find(pId);
            context.Products.Remove(found);
            context.SaveChanges();
        }

    }
}
