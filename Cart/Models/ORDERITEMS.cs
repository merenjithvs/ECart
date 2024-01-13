namespace Cart.Models
{
    public class ORDERITEMS
    {
        public int ORDERITEMID { get; set; }
        public int ORDERID { get; set; }
        public int PRODUCTID { get; set; }
        public int QUANTITY { get; set; }
        public decimal PRICE { get; set; }
    }
}
