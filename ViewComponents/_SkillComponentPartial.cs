using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents;

public class _SkillComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke() {  return View(); }
}
