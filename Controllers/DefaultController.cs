using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
