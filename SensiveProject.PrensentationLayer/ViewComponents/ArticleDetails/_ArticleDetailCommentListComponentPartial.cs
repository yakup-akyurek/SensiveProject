using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PrensentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailCommentListComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.i = id;
            
            var values = _commentService.TGetCommentsByArticleId(id);
            return View(values);
        }
    }
}
