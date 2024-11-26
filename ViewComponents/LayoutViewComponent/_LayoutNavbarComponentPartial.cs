using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.LayoutViewComponent;

public class _LayoutNavbarComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{

	return View(); 
	}
}
