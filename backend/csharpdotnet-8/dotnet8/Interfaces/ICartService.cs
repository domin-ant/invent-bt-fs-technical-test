using dotnet8.Models;

namespace dotnet8.Interfaces;

public interface ICartService
{
    List<Product> GetProducts();
    
    // New method to calculate total price
    double CalculateTotalPrice(string[] items);
} 