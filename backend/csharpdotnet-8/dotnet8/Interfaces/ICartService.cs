using dotnet8.Models;

namespace dotnet8.Interfaces;

public interface ICartService
{
    List<Product> GetProducts();
    double CalculateTotal(string[] items);
} 