using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductRepository
    {
        List<Product> List();
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);

        Product GetById(int id);


        List<Product> List(Expression<Func<Product, bool>> filter);

    }
}
