using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PrensentationLayer.ViewComponents
{
    public class _LastArticleComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _LastArticleComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetLastArticle();
            return View(values);
        }
    }
}
