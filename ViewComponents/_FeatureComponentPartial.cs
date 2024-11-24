using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
