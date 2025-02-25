using dotnet8.Controllers;
using dotnet8.Interfaces;
using dotnet8.Models;
using dotnet8.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet8_tests;

public class CartControllerTests
{
    [Fact]
    public void ShouldReturnListOfItems()
    {
        var cartService = new CartService();
        var controller = new CartController(cartService);

        var result = controller.GetShopItems();

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var itemsResponse = Assert.IsType<ItemsResponse>(okResult.Value);
        var productList = itemsResponse.ProductList;
        Assert.Equal("Apple", productList[0].ItemName);
        Assert.Equal(25, productList[1].Price);
    }
} 