namespace dotnet8.Models;

public class ItemsResponse
{
    public List<Product> ProductList { get; set; } = new();

    public ItemsResponse(List<Product> productList)
    {
        ProductList = productList;
    }
} 