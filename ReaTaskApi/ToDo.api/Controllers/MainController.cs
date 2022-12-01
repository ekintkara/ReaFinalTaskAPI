using Microsoft.AspNetCore.Mvc;

namespace ToDo.api.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
