using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
    return View(); 
    }
}
