namespace AddisEats.OrderBook.Services;
using AddisEats.OrderBook.Models;

public class OrderBook
{
     public  List<Order> Orders {get; set;} = new();

// returning orders for an area by total descending

    public void AddOrder(Order orders)
    {
        Orders.Add(orders);
    }
     public void DisplayResult(string Area, int N)
    {
        var result = Orders
        .Where(o => o.Area == Area)
        .OrderByDescending(o => o.Total);

        var TotalRevenue = result.Sum(r => r.Total);

        // var busiestCategory = result.Count(r => r.Lines.Item.Category);

        var TotalOrder = result.Count();

        var FivePerPage = result.Skip((N - 1) * 5).Take(5).ToList();

        Console.WriteLine($"Total Revenue:              {TotalRevenue} ETB");
        Console.WriteLine($"Total Orders:               {TotalOrder}");
        // Console.WriteLine("busiest Category :       ", busiestCategory);
        Console.WriteLine($"Page {N} is total :        {FivePerPage.Count} Orders");

        FivePerPage.Select(o => o.Customer).ToList();

    }
}