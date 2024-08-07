namespace EDA.Events;
public class OrderCreatedEvent
{
    public int OrderId { get; set; }
    public string? Product { get; set; }
    public int Quantity { get; set; }
}