using KombuchaShop.Models;
using KombuchaShop.Models.Repositories;
using KombuchaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KombuchaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IKombuchaRepository _repository;

        public HomeController(IKombuchaRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                KombuchasOfTheWeek = _repository.AllKombuchas.Where(x => x.IsKombuchaOfTheWeek = true).ToList()
            };
            return View(homeViewModel);
        }
    }
}