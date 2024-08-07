using EDA.DTO;
using EDA.Events;
using EDA.IService;
using EDA.Models;
namespace EDA.Service;
public class OrderService : IOrderService{
    public void CreateOrder(OrderDto orderDto)
        {
            var order = new Order
            {
                Id = new Random().Next(1, 1000),
                Product = orderDto.Product,
                Quantity = orderDto.Quantity
            };
            System.Console.WriteLine($"Order created: {order.Id} - {order.Product} - {order.Quantity}");
            // Publish event
            EventBus.Publish(new OrderCreatedEvent
            {
                OrderId = order.Id,
                Product = order.Product,
                Quantity = order.Quantity
            });
        }
}