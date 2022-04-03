using KombuchaShop.Models;
using System.Collections.Generic;

namespace KombuchaShop.ViewModels
{
    public class KombuchaListViewModel
    {
        public IEnumerable<Kombucha> Kombuchas { get; set; }
        public string CurrentCategory { get; set; }
    }
}