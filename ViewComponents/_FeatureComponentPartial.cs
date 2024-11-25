using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.DAL.Context;

namespace PersonalWebsite.ViewComponents;

public class _FeatureComponentPartial : ViewComponent
{
    private readonly PersonalWebsiteContext _context;

    public _FeatureComponentPartial(PersonalWebsiteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.Features.ToList();
        return View(values);
    }
}
