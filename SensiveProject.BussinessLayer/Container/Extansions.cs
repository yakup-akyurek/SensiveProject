using Microsoft.Extensions.DependencyInjection;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.BusinessLayer.Concrete;
using SensiveProject.DataAccess.Abstract;
using SensiveProject.DataAccess.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Container
{
    public static class Extansions
    {
        public static void ContainerDependicies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IArticleDal, EfArticleDal>();
            services.AddScoped<IArticleService, ArticleManager>();

            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
        }

    }
}
