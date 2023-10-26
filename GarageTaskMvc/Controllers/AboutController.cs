using Microsoft.AspNetCore.Mvc;

namespace GarageTaskMvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
