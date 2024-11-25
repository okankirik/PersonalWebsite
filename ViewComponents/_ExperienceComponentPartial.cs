using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.DAL.Context;

namespace PersonalWebsite.ViewComponents;

public class _ExperienceComponentPartial : ViewComponent
{
    private readonly PersonalWebsiteContext _context;

    public _ExperienceComponentPartial(PersonalWebsiteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var values = _context.Experiences.ToList();

    return View(values); 
    }
}
