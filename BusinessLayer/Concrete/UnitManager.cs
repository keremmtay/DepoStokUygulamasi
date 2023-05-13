using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UnitManager
    {
        GenericRepository<Unit> _repository = new GenericRepository<Unit>();

        public List<Unit> GetAllBL()
        {
            return _repository.List();
        }

        public string UnitAddBL(Unit unit)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (unit != null)
            {
                if (unit.BirimAdi != null && unit.BirimAdi != "")
                {
                    if (unit.BirimAdi.Length < 10)
                    {
                        _repository.Insert(unit);
                    }
                    else
                    {
                        mesaj = "Birim adı 10 karakterden uzun olamaz.";
                    }
                }
                else
                {
                    mesaj = "Birim Adı boş olamaz.";
                }
            }
            return mesaj;
        }

        public string UnitUpdateBL(Unit unit)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (unit != null)
            {
                if (unit.Id != 0 && unit.BirimAdi != null && unit.BirimAdi != "" && unit.BirimAdi.Length < 10)
                {
                    _repository.Update(unit, unit.Id);
                }
                else
                {
                    mesaj = "Birim Id, Birim Adı boş olamaz. Birim Adı 10 karakterden uzun olamaz.";
                }
            }
            return mesaj;
        }

        public void UnitDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
