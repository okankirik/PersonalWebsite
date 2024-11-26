using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers;

public class ExperienceController : Controller
{
    public IActionResult ExperienceList()
    {
        return View();
    }
}
