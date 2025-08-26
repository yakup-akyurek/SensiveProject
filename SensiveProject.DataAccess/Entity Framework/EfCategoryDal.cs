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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SensiveContext context) : base(context)
        {
        }
    }
}
