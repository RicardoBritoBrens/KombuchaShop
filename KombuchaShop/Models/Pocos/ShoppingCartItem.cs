namespace KombuchaShop.Models.Pocos
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Kombucha Kombucha { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}