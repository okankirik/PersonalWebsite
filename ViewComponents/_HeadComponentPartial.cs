using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _HeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {

    return View(); 
    }
}
