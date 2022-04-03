namespace KombuchaShop.Models
{
    public class Kombucha
    {
        public int KombuchaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NutritiveInformation { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}