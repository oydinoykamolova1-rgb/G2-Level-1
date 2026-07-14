namespace N28_T1.EwenBus;

public interface IEventBus
{
    void Subscribe<TEvent>(Func<TEvent, Task> handler);

    Task PublishAsync<TEvent>(TEvent @event);
}
