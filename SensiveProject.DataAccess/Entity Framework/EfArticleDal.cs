using Microsoft.EntityFrameworkCore;
using SensiveProject.DataAccess.Abstract;
using SensiveProject.DataAccess.Context;
using SensiveProject.DataAccess.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccess.Entity_Framework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(SensiveContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithAppUser()
        {
            var context=new SensiveContext();
            var values = context.Articles.Include(x=>x.Category).Include(x => x.AppUser).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategory()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(x=> x.Category).ToList();
            return values;
        }

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var context=new SensiveContext();
            var values=context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public Article GetLastArticle()
        {
            var context=new SensiveContext();
            var value = context.Articles.OrderByDescending(x => x.ArticleId).Take(1).FirstOrDefault();
            return value;
        }
    }
}
