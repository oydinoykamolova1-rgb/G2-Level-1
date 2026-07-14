using N28_T1.EwenBus;

namespace N28_T1.EventBus;

public class InMemoryEventBus : IEventBus
{
    private readonly Dictionary<Type, List<Func<object, Task>>>
        _handlers = new();

    public void Subscribe<TEvent>(Func<TEvent, Task> handler)
    {
        var eventType = typeof(TEvent);

        if (!_handlers.TryGetValue(eventType, out var handlersList))
        {
            handlersList = new List<Func<object, Task>>();
            _handlers[eventType] = handlersList;
        }
        handlersList.Add(e => handler((TEvent)e));
    }

    public async Task PublishAsync<TEvent>(TEvent @event)
    {
        var eventType = typeof(TEvent);

        if (!_handlers.TryGetValue(eventType, out var handlersList))
        {
            Console.WriteLine($"[EventBus] Hech qanday subscriber topilmadi: {eventType.Name}");
            return;
        }

        foreach (var handler in handlersList)
            await handler(@event)!;
    }
}
