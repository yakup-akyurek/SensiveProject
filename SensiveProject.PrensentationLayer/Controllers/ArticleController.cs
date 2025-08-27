using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using System.Drawing.Text;

namespace SensiveProject.PrensentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TGetAll();


            return View(values);
        }
    }
}
