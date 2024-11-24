using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _FooterComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
    return View(); 
    }
}
