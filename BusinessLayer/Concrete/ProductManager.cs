using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        GenericRepository<Product> _repository = new GenericRepository<Product>();

        public List<Product> GetAllBL()
        {
            return _repository.List();
        }

        public string ProductAddBL(Product product)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (product != null)
            {
                if (product.UrunAdi != null && product.UrunAdi != "" && product.StokMiktari != 0  && product.CategoryId != 0 && product.UnitId != 0 && product.WarehouseId != 0)
                {
                    if (product.UrunAdi.Length < 20)
                    {
                        _repository.Insert(product);
                    }
                    else
                    {
                        mesaj = "Ürün adı 20 karakterden uzun olamaz.";
                    }
                }
                else
                {
                    mesaj = "Ürün Adı, Stok Miktarı, Kategori Id, Unit Id, Warehouse Id boş olamaz.";
                }

            }
            return mesaj;
        }

        internal void StockUpdateBL(ICollection<StockOperationDetails> stockDetails, string islemTuru)
        {
            foreach (var item in stockDetails)
            {
                Product product = _repository.GetById(item.ProductId);

                if (islemTuru == "Giriş İşlemi")
                {
                    product.StokMiktari += item.Adet;
                }
                else if (islemTuru == "Çıkış İşlemi")
                {
                    product.StokMiktari -= item.Adet;
                }

                ProductUpdateBL(product);
            }
        }

        public string ProductUpdateBL(Product product)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (product != null)
            {
                if (product.Id != 0 && product.UrunAdi != null && product.UrunAdi != "" && product.StokMiktari != 0 && product.CategoryId != 0 && product.UnitId != 0 && product.WarehouseId != 0 && product.UrunAdi.Length < 20)
                {
                    _repository.Update(product, product.Id);
                }
                else
                {
                    mesaj = "Ürün Adı, Stok Miktarı, Kategori Id, Unit Id, Warehouse Id boş olamaz. Ürün Adı 20 karakterden uzun olamaz.";
                }

            }

            return mesaj;
        }

        public void ProductDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }            
        }

        public List<Product> SearchByProductName(string name)
        {
            return _repository.List(x => x.UrunAdi.Contains(name));
        }

        public Product Find(int id)
        {
            return _repository.GetById(id);
        }

    }

}
