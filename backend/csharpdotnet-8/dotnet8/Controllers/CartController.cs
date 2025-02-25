using dotnet8.Interfaces;
using dotnet8.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet8.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    public ActionResult<double> GetTotalPrice([FromBody] string[] items)
    {
        if (items == null)
        {
            return BadRequest("Items array cannot be null");
        }

        return Ok(_cartService.CalculateTotal(items));
    }
} 