namespace KombuchaShop.Models
{
    public class Kombucha
    {
        public int KombuchaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NutritiveInformation { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsKombuchaOfTheWeek { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }
    }
}