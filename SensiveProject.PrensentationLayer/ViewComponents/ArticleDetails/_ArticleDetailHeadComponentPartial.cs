using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PrensentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
