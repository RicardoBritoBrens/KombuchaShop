using Microsoft.AspNetCore.Mvc;

namespace KombuchaShop.Controllers
{
    public class KombuchaController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}