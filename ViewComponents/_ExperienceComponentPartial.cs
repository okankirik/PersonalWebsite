using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {

    return View(); 
    }
}
