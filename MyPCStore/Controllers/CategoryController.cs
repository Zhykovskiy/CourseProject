using Microsoft.AspNetCore.Mvc;

namespace MyPCStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
