using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WarehouseManager
    {
        GenericRepository<Warehouse> _repository = new GenericRepository<Warehouse>();

        public List<Warehouse> GetAllBL()
        {
            return _repository.List();
        }

        public string WarehouseAddBL(Warehouse warehouse)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (warehouse != null)
            {
                if (warehouse.DepoAdi != null && warehouse.DepoAdi != "")
                {
                    if (warehouse.DepoAdi.Length < 20 && warehouse.DepoYetkilisi.Length < 30 && warehouse.Telefon.Length < 15)
                    {
                        _repository.Insert(warehouse);
                    }
                    else
                    {
                        mesaj = "Depo Adı 20, Depo Yetkilisi 30, Telefon 15 karakterden uzun olamaz.";
                    }
                }
                else
                {
                    mesaj = "Depo Adı boş geçilemez.";
                }
            }

            return mesaj;
        }

        public string WarehouseUpdateBL(Warehouse warehouse)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (warehouse != null)
            {
                if (warehouse.Id != 0 && warehouse.DepoAdi != null && warehouse.DepoAdi != "")
                {
                    if (warehouse.DepoAdi.Length < 20 && warehouse.DepoYetkilisi.Length < 30 && warehouse.Telefon.Length < 15)
                    {
                        _repository.Update(warehouse, warehouse.Id);
                    }
                    else
                    {
                        mesaj = "Depo Adı 20, Depo Yetkilisi 30, Telefon 15 karakterden uzun olamaz.";
                    }
                }
                else
                {
                    mesaj = "Depo Id ve Depo Adı boş geçilemez.";
                }
            }

            return mesaj;
        }

        public void WarehouseDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
