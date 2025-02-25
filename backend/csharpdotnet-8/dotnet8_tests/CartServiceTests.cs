using dotnet8.Services;
using Xunit;

namespace dotnet8_tests;

public class CartServiceTests
{
    private readonly CartService _cartService;

    public CartServiceTests()
    {
        _cartService = new CartService();
    }

    [Fact]
    public void GetProducts_ReturnsCorrectProducts()
    {
        // Act
        var products = _cartService.GetProducts();

        // Assert
        Assert.Equal(2, products.Count);
        Assert.Contains(products, p => p.ItemName == "Apple" && p.Price == 60);
        Assert.Contains(products, p => p.ItemName == "Orange" && p.Price == 25);
    }

    [Fact]
    public void CalculateTotal_WithNullItems_ReturnsZero()
    {
        // Act
        var total = _cartService.CalculateTotal(null);

        // Assert
        Assert.Equal(0, total);
    }

    [Fact]
    public void CalculateTotal_WithEmptyItems_ReturnsZero()
    {
        // Act
        var total = _cartService.CalculateTotal(Array.Empty<string>());

        // Assert
        Assert.Equal(0, total);
    }

    [Fact]
    public void CalculateTotal_WithValidItems_ReturnsCorrectTotal()
    {
        // Arrange
        var items = new[] { "Apple", "Apple", "Orange", "Apple" };

        // Act
        var total = _cartService.CalculateTotal(items);

        // Assert
        Assert.Equal(2.05, total);
    }

    [Fact]
    public void CalculateTotal_WithInvalidItems_IgnoresInvalidItems()
    {
        // Arrange
        var items = new[] { "Apple", "Banana", "Orange", "Grape" };

        // Act
        var total = _cartService.CalculateTotal(items);

        // Assert
        Assert.Equal(0.85, total);
    }

    [Fact]
    public void CalculateTotal_WithMixedCaseItems_IsCaseInsensitive()
    {
        // Arrange
        var items = new[] { "apple", "APPLE", "Orange", "oRaNgE" };

        // Act
        var total = _cartService.CalculateTotal(items);

        // Assert
        Assert.Equal(1.70, total);
    }
} 