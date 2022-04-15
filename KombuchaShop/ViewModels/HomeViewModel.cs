using KombuchaShop.Models;
using System.Collections.Generic;

namespace KombuchaShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Kombucha> KombuchasOfTheWeek { get; set; }
    }
}