using Microsoft.AspNetCore.Mvc;

namespace ReaFinalTask.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
