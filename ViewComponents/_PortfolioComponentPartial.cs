using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.DAL.Context;

namespace PersonalWebsite.ViewComponents;

public class _PortfolioComponentPartial : ViewComponent
{
    

    public IViewComponentResult Invoke()
    {
    return View(); 
    }
}
