using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class CartItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
