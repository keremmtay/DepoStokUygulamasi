using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> List();
        void Insert(Category category);
        void Update(Category category);
        void Delete(int id);

        Category GetById(int id);


        List<Category> List(Expression<Func<Category, bool>> filter);
    }
}
