using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> _repository = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
             return _repository.List();
        }

        public string CategoryAddBL(Category category)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (category != null)
            {
                if (category.KategoriAdi != null && category.KategoriAdi != "")
                {
                    if (category.KategoriAdi.Length > 3 && category.KategoriAdi.Length < 31)
                    {
                        _repository.Insert(category);
                    }
                    else
                    {
                        mesaj = "Kategori Adı en az 3, en fazla 30 karakter olmalıdır.";
                    }
                    
                }
                else
                {
                    mesaj = "Kategori adı boş geçilemez.";
                }
            }


            return mesaj;
        }

        public string CategoryUpdateBL(Category category)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (category != null)
            {
                if (category.Id != 0 && category.KategoriAdi != "" && category.KategoriAdi.Length >3 && category.KategoriAdi.Length < 31)
                {
                    _repository.Update(category, category.Id);
                }
                else
                {
                    mesaj = "Kategori Id ve Kategori Adı boş  olamaz. Kategori Adı 4 ile 30 karakter arasında olmalı.";
                }
            }

            return mesaj;
        }

        public void CategoryDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }

        }
    }
}
