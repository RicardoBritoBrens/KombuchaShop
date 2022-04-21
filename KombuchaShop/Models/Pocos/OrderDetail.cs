namespace KombuchaShop.Models.Pocos
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int KombuchaId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Kombucha Kombucha { get; set; }
        public Order Order { get; set; }
    }
}