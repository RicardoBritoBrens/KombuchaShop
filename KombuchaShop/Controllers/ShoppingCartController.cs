using KombuchaShop.Models;
using KombuchaShop.Models.Repositories;
using KombuchaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KombuchaShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IKombuchaRepository _repository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IKombuchaRepository repository, ShoppingCart shoppingCart)
        {
            _repository = repository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int KombuchaId)
        {
            var selectedPie = _repository.AllKombuchas.FirstOrDefault(p => p.KombuchaId == KombuchaId);

            if (selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int KombuchaId)
        {
            var selectedPie = _repository.AllKombuchas.FirstOrDefault(p => p.KombuchaId == KombuchaId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}