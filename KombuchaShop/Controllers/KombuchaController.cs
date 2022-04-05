using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KombuchaShop.Models;
using KombuchaShop.Models.Repositories;
using System.Linq;
using KombuchaShop.ViewModels;

namespace KombuchaShop.Controllers
{
    public class KombuchaController : Controller
    {
        private readonly IKombuchaRepository _kombuchaRepository;
        private readonly ICategoryRepository _categoryRepository;

        public KombuchaController(IKombuchaRepository kombuchaRepository, ICategoryRepository categoryRepository)
        {
            _kombuchaRepository = kombuchaRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Kombucha> pies;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _kombuchaRepository.AllKombuchas.OrderBy(p => p.KombuchaId);
                currentCategory = "All Kombuchas";
            }
            else
            {
                pies = _kombuchaRepository.AllKombuchas.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.KombuchaId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new KombuchaListViewModel
            {
                Kombuchas = pies,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var kombucha = _kombuchaRepository.GetKombuchaById(id);
            if (kombucha == null) {
                return NotFound();
            }
            return View(kombucha);
        }
    }
}