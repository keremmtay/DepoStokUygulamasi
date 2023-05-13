using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StockOperationDetailManager
    {
        GenericRepository<StockOperationDetails> repository = new GenericRepository<StockOperationDetails>();

        public List<StockOperationDetails> ListDetails(int id)
        {
            return repository.List(x => x.StockOperationId == id);
        }



    }
}
