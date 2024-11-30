using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class OrderItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
