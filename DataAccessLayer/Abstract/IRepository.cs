using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Insert(T entity);
        void Update(T entity, int id);
        void Delete(int id);

        T GetById(int id);


        List<T> List(Expression<Func<T, bool>> filter);
    }
}
