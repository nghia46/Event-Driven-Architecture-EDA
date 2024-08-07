using EDA.DTO;
namespace EDA.IService;

public interface IOrderService
{
    void CreateOrder(OrderDto orderDto);
}
