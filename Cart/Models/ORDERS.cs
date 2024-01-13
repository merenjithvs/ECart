namespace Cart.Models
{
    public class ORDERS
    {
        public int ORDERID { get; set; }
        public int CUSTOMERID { get; set; }
        public DateTime ORDERDATE { get; set; }
        public DateTime DELIVERYEXPECTED { get; set; }
        public bool CONTAINSGIFT { get; set; }
    }
}
