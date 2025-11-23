using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccess.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
    {
        List<Article> ArticleListWithCategory();
        List<Article> ArticleListWithAppUser();

        Article GetLastArticle();

        List<Article> GetArticlesByAppUserId(int id);
    }
}
