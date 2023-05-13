using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StockOperationManager
    {
        GenericRepository<StockOperation> repository = new GenericRepository<StockOperation>();

        public List<StockOperation> GetAllBL()
        {
            return repository.List();
        }

        public List<StockOperation> GetAllBL(string islemTuru)
        {
            return repository.List(x => x.IslemTuru == islemTuru);
        }

        public string StockOperationAddBL(StockOperation stockOperation)
        {
            string mesaj = "İşlem başarılı";

            if (stockOperation != null)
            {
                if (stockOperation.IslemTarihi != null && stockOperation.CompanyId != 0 && stockOperation.IslemTuru != "")
                {
                    repository.Insert(stockOperation);

                    ProductManager productManager = new ProductManager();

                    productManager.StockUpdateBL(stockOperation.StockOperationDetails ,stockOperation.IslemTuru);
                }
            }
            else
            {
                mesaj = "Kaydedilecek veri gönderilmedi.";
            }

            return mesaj;
        }

        public void StockOperationDeleteBL(int id)
        {
            if (id > 0)
            {
                StockOperation stockOperation = Find(id);

                ProductManager productManager = new ProductManager();

                foreach (var sod in stockOperation.StockOperationDetails)
                {
                    Product p = productManager.Find(sod.ProductId);

                    if (stockOperation.IslemTuru == "Giriş İşlemi")
                    {
                        p.StokMiktari -= sod.Adet;
                    }
                    else if (stockOperation.IslemTuru == "Çıkış İşlemi")
                    {
                        p.StokMiktari += sod.Adet;
                    }

                    productManager.ProductUpdateBL(p);
                }

                repository.Delete(id);
            }
        }

        public StockOperation Find(int id)
        {
            return repository.GetById(id);
        }
    }
}
