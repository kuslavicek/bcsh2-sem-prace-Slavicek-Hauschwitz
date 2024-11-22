public class OrderStatistics
{
    public int TotalOrders { get; set; }
    public double AveragePrice { get; set; }
    public double TotalPrice { get; set; }
    public int CompletedOrders { get; set; }
    public int PendingOrders { get; set; }
    public double MostExpensiveOrder { get; set; }
    public string MostExpensiveCustomer { get; set; }
    public double LeastExpensiveOrder { get; set; }
    public string LeastExpensiveCustomer { get; set; }
}
