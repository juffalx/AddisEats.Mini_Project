namespace AddisEats.OrderBook.Models;

public class Order
{
    public List<OrderLine>  Lines {get; set;}= new();
    public string Customer {get; set;}
    public string Area {get; set;}
    public decimal Total  => Lines.Sum(r => r.Item.Price  * r.Quantity);
}

 // Order ሲደረግ የሚይዛቸው intitiy