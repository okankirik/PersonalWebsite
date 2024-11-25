using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.DAL.Context;

namespace PersonalWebsite.ViewComponents;

public class _SkillComponentPartial : ViewComponent
{
    private readonly PersonalWebsiteContext _context;

    public _SkillComponentPartial(PersonalWebsiteContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke() { 
       
        var values = _context.Skills.ToList();

        return View(values); 
    }
}
