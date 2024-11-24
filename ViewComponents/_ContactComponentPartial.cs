using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }
    }
}
