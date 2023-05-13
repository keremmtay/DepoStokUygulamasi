using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyManager
    {
        GenericRepository<Company> _repository = new GenericRepository<Company>();

        public List<Company> GetAllBL()
        {
            return _repository.List();
        }

        public string CompanyAddBL(Company company)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (company != null)
            {
                if (company.FirmaAdi != null && company.FirmaAdi != "" && company.FirmaAdi.Length < 25 && company.FirmaTuru != null && company.FirmaTuru != "" && company.FirmaTuru.Length < 15 && company.Adres.Length < 100 && company.Telefon.Length < 15 && company.Email.Length < 30 && company.YetkiliKisi.Length < 30 && company.Aciklama.Length < 100 && company.VergiNo.Length < 15 && company.HesapNo.Length < 16)
                {
                    _repository.Insert(company);
                }
                else
                {
                    mesaj = "Firma Adı ve Firma Türü boş geçilemez. Firma Adı 25, Firma Türü 15, Adres 100, Telefon 15, Email 30, Yetkili Kişi 30, Açıklama 100, Vergi No 15, Hesap No 16 karakterden uzun olamaz.";
                }                
            }

            return mesaj;
        }

        public string CompanyUpdateBL(Company company)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (company != null)
            {
                if (company.Id != 0 && company.FirmaAdi != null && company.FirmaAdi != "" && company.FirmaAdi.Length < 25 && company.FirmaTuru != null && company.FirmaTuru != "" && company.FirmaTuru.Length < 15 && company.Adres.Length < 100 && company.Telefon.Length < 15 && company.Email.Length < 30 && company.YetkiliKisi.Length < 30 && company.Aciklama.Length < 100 && company.VergiNo.Length < 15 && company.HesapNo.Length < 16)
                {
                    _repository.Update(company, company.Id);
                }
                else
                {
                    mesaj = "Id, Firma Adı ve Firma Türü boş geçilemez. Firma Adı 25, Firma Türü 15, Adres 100, Telefon 15, Email 30, Yetkili Kişi 30, Açıklama 100, Vergi No 15, Hesap No 16 karakterden uzun olamaz.";
                }
            }

            return mesaj;
        }

        public void CompanyDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }
    }
}
