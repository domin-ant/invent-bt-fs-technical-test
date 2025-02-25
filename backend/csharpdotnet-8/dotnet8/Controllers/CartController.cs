using dotnet8.Interfaces;
using dotnet8.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet8.Controllers;

[ApiController]
[Produces("application/json")]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [Route("items")]
    [HttpGet]
    public ActionResult<ItemsResponse> GetShopItems()
    {
        return Ok(new ItemsResponse(_cartService.GetProducts()));
    }

    [Route("total")]
    [HttpPost]
    public ActionResult<double> GetTotalPrice(string[] items)
    {
        throw new NotImplementedException();
    }
} 