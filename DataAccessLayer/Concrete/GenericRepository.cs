using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
        // bizim buraya göndereceğimiz parametre Entity class'ları olacağı için T değerine class kısıtı uygulamış olduk.
    {
        // Bir önceki yapıyı 2 farklı tabloyu temsil eden işlemler için kurmuştuk. Toplamda 8 farklı tablomuz olacağından her biri için zorunda kalacaktık. Bir noktada yapılacak olan bir değişiklik bir çok sınıfı etkileyecek. Örneğin yeni bir metod eklemek istiyorsam her bir sınıfa bunu ayrı ayrı eklemem gerekecek. Bu yapı, yönetilebilir bir yapı değil ve yazılımcının üzerinde çok fazla kod yükü oluşturacak. Yani çok fazla kod yazmak zorunda kalacağız.

        // Bu yapı yerine GenericRepository tasarım desenini uygulayarak, bu kod yükünden kurtulmuş oluyoruz.

        // Genel olarak Veritabanı işlemleri, bütün tablo veya entity'ler için aynıdır. Bu kodları tekrar tekrar yazmak yerine Generic dediğimiz bu yapı ile kolayca çözüyoruz. 

        Context context = new Context();

        DbSet<T> _dbSet;

        public GenericRepository()
        {
            _dbSet = context.Set<T>();
        }


        public void Delete(int id)
        {
            try
            {
                var result = _dbSet.Find(id);
                _dbSet.Remove(result);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Silme hatası...: " + ex.Message);                
            }
        }

        public T GetById(int id)
        {
            T result = _dbSet.Find(id);
            return result;
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            // FirstOrDefault() ile bulunan ilk kayıt tablodan getirilir.

            T result = _dbSet.Where(filter).FirstOrDefault();
            return result;
        }

        public void Insert(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kayıt eklenirken bir hata oluştu...: " + ex.Message);
                
            }
        }

        public List<T> List()
        {
            return _dbSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public void Update(T entity, int id)
        {
            // Güncellemek istediğimiz nesneyi veritabanından buluyoruz. 

            T guncellenecekNesne = _dbSet.Find(id);

            // Hangi Entity için kullanılacaksa, benim o entity'ler için ilgili property'leri bilmem gerekiyor.

            var tumPropertyler = typeof(T).GetProperties();

            // typeof(T) : nesnenin türünü veriyor. Category, Product, Company etc.

            // GetProperties() : Eğer nesnemiz Category ise, Category entity'sinin içindeki bütün property'leri, tümPropertyler isimli değişkene atıyor.

            // Daha sonra parametre ile gelen veriyi, veritabanından bulduğumuz nesnenin içine yerleştiriyoruz.

            // Döngü içerisinde ilgili property'lere bizim gönderdiğimiz entity içindeki verileri atıyoruz. Id property'sini muaf tutuyoruz.

            foreach (var property in tumPropertyler)
            {
                if (property.Name != "Id")
                {
                    property.SetValue(guncellenecekNesne, property.GetValue(entity));
                }
            }

            // Son olarak da ilgili nesneyi SaveChanges metodu ile veritabanına kaydediyoruz.

            context.SaveChanges();
        }
    }
}
