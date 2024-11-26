using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents.LayoutViewComponent;

public class _LayoutScriptComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{

	return View(); }
}
