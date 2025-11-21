using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PrensentationLayer.ViewComponents
{
    public class _ArticleListHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
