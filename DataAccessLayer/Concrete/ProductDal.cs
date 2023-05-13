using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    internal class ProductDal : IProductRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> List()
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductRepository.List(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
