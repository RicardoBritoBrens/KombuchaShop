using System.Collections.Generic;

namespace KombuchaShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Kombucha> Kombuchas { get; set; }
    }
}