using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PrensentationLayer.ViewComponents.AIrticleDetails
{
    public class _ArticleDetailListComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
           
            var value = _articleService.TGetById(id);
            return View(value);
        }
    }
}
