using dotnet8.Interfaces;
using dotnet8.Models;

namespace dotnet8.Services;

public class CartService : ICartService
{
    private readonly List<Product> _products = new();

    public CartService()
    {
        _products.Add(new Product("Apple", 60));
        _products.Add(new Product("Orange", 25));
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public double CalculateTotalPrice(string[] items)
    {
        throw new NotImplementedException();
    }
} 