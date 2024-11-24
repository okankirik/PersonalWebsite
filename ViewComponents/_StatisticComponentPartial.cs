using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _StatisticComponentPartial : ViewComponent
{
    public  IViewComponentResult Invoke()
    {
    return View(); }
}
