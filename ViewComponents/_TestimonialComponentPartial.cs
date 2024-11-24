using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _TestimonialComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
    return View(); }
}
