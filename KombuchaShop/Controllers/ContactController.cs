using Microsoft.AspNetCore.Mvc;

namespace KombuchaShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
