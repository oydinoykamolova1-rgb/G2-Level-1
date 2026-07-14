using N28_T1.EventBus;
using N28_T1.EwenBus;
using N28_T1.Ewents;
using N28_T1.Models;

var EwenBus = new InMemoryEventBus();

EwenBus.Subscribe<OrderCreatedEvent>(e =>

{
    Console.WriteLine($"[OrderCreatedEvent] OrderCreatedEvent keldi: {e.OrderId}," +
        $"User Id:{e.UserId}, Amount:{e.Amount}");
    return Task.CompletedTask;
});

EwenBus.Subscribe<BonusEchievendEvent>(e =>
{
    Console.WriteLine($"[Handler] BonusAchievedEvent keldi: {e.UserId}, {e.OldBonus},-> {e.NewBonus}");
    return Task.CompletedTask;
});


var User = new User
{
    Id = 1,
    FullName = "Kamolova Oydinoy",
    Email = "kamolovaoydinoy1@gamil.com",
    Bonus = new Bonus { Id = 1, UserId = 1, TotalAmount = 89m },
};
async Task CreateOrderAsync(User forUser, decimal amount)
{
    var order = new Order
    {
        Id = 1,
        UserId = forUser.Id,
        Amount = amount,
        CreatedAt = DateTime.UtcNow
    };
    Console.WriteLine($"[CreateOrderAsync] Order yaratildi: {order.Id}, User Id: {order.UserId}, Amount: {order.Amount}");
    await EwenBus.PublishAsync(new OrderCreatedEvent
    {
        OrderId = order.Id,
        UserId = order.UserId,
        Amount = order.Amount
    });
    // Bonus hisoblash logikasi
    var oldBonus = forUser.Bonus?.TotalAmount ?? 0m;
    var newBonus = oldBonus + (amount * 0.1m); // Masalan, 10% bonus
    if (newBonus > oldBonus)
    {
        forUser.Bonus!.TotalAmount = newBonus;
        await EwenBus.PublishAsync(new BonusEchievendEvent
        {
            UserId = forUser.Id,
            OldBonus = oldBonus,
            NewBonus = newBonus
        });
    }
}
await CreateOrderAsync(User, amount: 100m);
await CreateOrderAsync(User, amount: 50m);
await CreateOrderAsync(User, amount: 40m);
Console.WriteLine(value: $"\nUser '{User.FullName} has a total bonus of {User.Bonus?.TotalAmount ?? 0m}");