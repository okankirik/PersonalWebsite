using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.DAL.Context;

namespace PersonalWebsite.ViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    private readonly PersonalWebsiteContext _context;

    public _AboutComponentPartial(PersonalWebsiteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        ViewBag.title = _context.Abouts.Select(x => x.Title).FirstOrDefault();
        ViewBag.subDescription = _context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
        ViewBag.detail = _context.Abouts.Select(x => x.Details).FirstOrDefault();
    return View(); 
    }
}
