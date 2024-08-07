using Microsoft.AspNetCore.Mvc;
using EDA.IService;
using EDA.DTO;
namespace EDA.Controller;
[Controller]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    [HttpPost]
    public IActionResult CreateOrder([FromBody] OrderDto orderDto)
    {
        _orderService.CreateOrder(orderDto);
        return Ok();
    }
}