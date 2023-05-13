using DataAccessLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager
    {
        GenericRepository<Employee> _repository = new GenericRepository<Employee>();

        public List<Employee> GetAllBL()
        {
            return _repository.List();
        }

        public List<Employee> GetActivePersonels()
        {
            return _repository.List(x => x.AktifMi == true);
        }

        public List<Employee> GetNonActivePersonels()
        {
            return _repository.List(x => x.AktifMi == false);
        }

        public string EmployeeAddBL(Employee employee)
        {
            string mesaj = "Kaydetme işlemi başarılı.";

            if (employee != null)
            {
                if (employee.Adi != null && employee.Adi != "" && employee.Soyadi != null && employee.Soyadi != "" && employee.Gorevi.Length < 20 && employee.KullaniciAdi != null && employee.KullaniciAdi != "" && employee.KullaniciAdi.Length < 20 && employee.Sifre != null && employee.Sifre != "" && employee.Sifre.Length < 20)
                {
                    _repository.Insert(employee);
                }
                else
                {
                    mesaj = "Çalışan Adı, Soyadı, Görevi, Kullanıcı Adı, Şifresi ve Durumu boş geçilemez. Bu alanlara 20 karakterden fazlası yazılamaz.";
                }
            }
            return mesaj;
        }

        public string EmployeeUpdateBL(Employee employee)
        {
            string mesaj = "Güncelleme işlemi başarılı.";

            if (employee != null)
            {
                if (employee.Id != 0 && employee.Adi != null && employee.Adi != "" && employee.Soyadi != null && employee.Soyadi != "" && employee.Gorevi.Length < 20 && employee.KullaniciAdi != null && employee.KullaniciAdi != "" && employee.KullaniciAdi.Length < 20 && employee.Sifre != null && employee.Sifre != "" && employee.Sifre.Length < 20)
                {
                    _repository.Update(employee, employee.Id);
                }
                else
                {
                    mesaj = "Çalışan Id, Adı, Soyadı, Görevi, Kullanıcı Adı, Şifresi ve Durumu boş geçilemez. Bu alanlara 20 karakterden fazlası yazılamaz.";
                }
            }
            return mesaj;
        }

        public void EmployeeDeleteBL(int id)
        {
            if (id != 0)
            {
                _repository.Delete(id);
            }
        }

        public bool IsUserExists(string userName)
        {
            bool result = false;

            Employee employee = _repository.Get(x => x.KullaniciAdi == userName && x.AktifMi == true);

            if (employee != null)
            {
                result = true;
            }

            return result;
        }

        public bool CheckUserNameAndPassword(string username, string password)
        {
            bool result = false;

            var employee = _repository.Get(x => x.KullaniciAdi == username && x.Sifre == password && x.AktifMi == true);

            if (employee != null)
            {
                result = true;
            }

            return result;
        }
    }
}
