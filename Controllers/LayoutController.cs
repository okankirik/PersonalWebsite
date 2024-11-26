using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
