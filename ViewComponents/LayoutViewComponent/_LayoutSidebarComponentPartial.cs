using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.LayoutViewComponent;

public class _LayoutSidebarComponentPartial :ViewComponent
{
	public IViewComponentResult Invoke()
	{

	return View(); }
}
