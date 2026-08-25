using Newtonsoft.Json;

var payload = Console.In.ReadToEnd();
var order = JsonConvert.DeserializeObject<Order>(payload);

Console.WriteLine($"Received order {order?.Id} for {order?.Item}");

class Order
{
    public string? Id { get; set; }
    public string? Item { get; set; }
}
