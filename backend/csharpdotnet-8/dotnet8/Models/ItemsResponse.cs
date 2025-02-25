namespace dotnet8.Models;

public class ItemsResponse
{
    public List<Product> Products { get; set; }

    public ItemsResponse(List<Product> products)
    {
        Products = products;
    }
} 