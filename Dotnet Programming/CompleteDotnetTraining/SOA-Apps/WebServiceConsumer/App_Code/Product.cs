using myWebServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product_
/// </summary>
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Image { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}

public class ProductRepository
{
    public static List<Product> GetAllProducts()
    {
        var proxy = new ProductService();
        var table = proxy.GetAllProducts();
        var list = new List<Product>();
        foreach(DataRow row in table.Rows)
        {
            var product = new Product
            {
                Image = row[2].ToString(),
                Price = int.Parse(row[3].ToString()),
                ProductId = int.Parse(row[0].ToString()),
                ProductName = row[1].ToString(),
                Quantity = int.Parse(row[4].ToString())
            };
            list.Add(product);
        }
        return list;
    }
}