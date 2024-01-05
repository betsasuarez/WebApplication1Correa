using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Descripción breve de SupermarketService
/// </summary>
public class SupermarketService : ISupermarketService
{
    private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Pollo", Price = 0.5m, Quantity = 10 },
        new Product { Id = 2, Name = "Leche", Price = 0.3m, Quantity = 20 },
        new Product { Id = 3, Name = "Arroz", Price = 0.7m, Quantity = 15 }
    };

    public List<Product> GetProducts()
    {
        return products;
    }

    public Product GetProduct(int id)
    {
        return products.FirstOrDefault(p => p.Id == id);
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Quantity = product.Quantity;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            products.Remove(product);
        }
    }
}