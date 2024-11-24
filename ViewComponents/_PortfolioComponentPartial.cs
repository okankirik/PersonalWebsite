using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _PortfolioComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
    return View(); 
    }
}
