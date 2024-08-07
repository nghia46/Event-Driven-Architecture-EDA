using EDA.Events;
public class EventBus
{
    private static readonly List<Action<OrderCreatedEvent>> _handlers = new();

    public static void Subscribe(Action<OrderCreatedEvent> handler)
    {
        _handlers.Add(handler);
    }

    public static void Publish(OrderCreatedEvent orderCreatedEvent)
    {
        System.Console.WriteLine("Event published " + orderCreatedEvent.OrderId);
        foreach (var handler in _handlers)
        {
            handler(orderCreatedEvent);
        }
    }
}