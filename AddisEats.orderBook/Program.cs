using AddisEats.OrderBook.Models;

var doro = new MenuItem(1, "Doro Wat", "Traditional", 450m);
var shiro = new MenuItem(2, "Shiro", "Traditional", 150m);
var tibs =  new MenuItem(3, "Tibs", "Moderate", 400m);

var order = new Order
{
    Customer = "Abel",
    Area = "Bole",
    Lines = new List<OrderLine>
    {
        new(doro, 2),
        new(shiro, 1),
        new(tibs, 3)
    }
};

Console.WriteLine($"Customer: {order.Customer}");
Console.WriteLine($"Area: {order.Area}");
Console.WriteLine($"Total: {order.Total} ETB");