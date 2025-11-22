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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(SensiveContext context) : base(context)
        {
        }

        public List<Comment> GetCommentsByArticleId(int id)
        {
            var context=new SensiveContext();
            var values = context.Comments.Where(x => x.ArticleId == id).Include(x=>x.Article).Include(y=>y.AppUser).ToList();
            return values;
        }
    }
    
}
