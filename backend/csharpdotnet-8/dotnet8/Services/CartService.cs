using dotnet8.Interfaces;
using dotnet8.Models;

namespace dotnet8.Services;

public class CartService : ICartService
{
    private readonly List<Product> _products = new()
    {
        new Product("Apple", 60),
        new Product("Orange", 25)
    };

    public List<Product> GetProducts()
    {
        return _products;
    }

    public double CalculateTotal(string[] items)
    {
        if (items == null || items.Length == 0)
        {
            return 0;
        }

        double total = 0;

        foreach (var item in items)
        {
            var product = _products.FirstOrDefault(p => 
                p.ItemName.Equals(item, StringComparison.OrdinalIgnoreCase));
            
            if (product != null)
            {
                total += product.Price;
            }
        }

        return total / 100.0; // Convert from pence to pounds
    }
} 