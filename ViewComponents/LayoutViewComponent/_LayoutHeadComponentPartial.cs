using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.LayoutViewComponent;

public class _LayoutHeadComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{

	return View(); 
	}
}
