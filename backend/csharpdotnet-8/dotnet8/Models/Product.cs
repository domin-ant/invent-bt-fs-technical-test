namespace dotnet8.Models;

public class Product
{
    public string ItemName { get; set; } = string.Empty;

    public int Price { get; set; }

    public Product(string itemName, int price)
    {
        ItemName = itemName;
        Price = price;
    }
} 