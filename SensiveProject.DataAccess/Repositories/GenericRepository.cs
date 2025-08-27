using SensiveProject.DataAccess.Abstract;
using SensiveProject.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccess.Repositories
{
    //Generic Repository = “CRUD işlemlerini tek yerde yaz, tüm entity’lerde tekrar tekrar kullan.”
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SensiveContext _context;

        //yapıcı metot sınıfın ismiyle olmalı ki o sınıfın yapıcı metodu olmalı, bu sınıf çağrıldığında new'leme işlemine gerek yok,bu sayede bağımlılığımızı azaltıyoruz***.olabildiğince sınıfları devredışı bırakarak işlemleri interface ler ile yapıcaz.
        public GenericRepository(SensiveContext context)
        {
            _context = context;
        }

      
       
        public void Delete(int id)
        {
           var value=_context.Set<T>().Find(id); //id'ye göre bulma işlemi yapıldı.
            _context.Set<T>().Remove(value); //bulunan değeri silme işlemi yapıldı.
            _context.SaveChanges(); //değişikliklerin kaydedilmesi için SaveChanges metodu çağrıldı.
        }
        //void olamayanlar return eder
        public List<T> GetAll() 
        {
            return _context.Set<T>().ToList(); //T tipindeki tüm verileri listeye çevirme işlemi yapıldı.
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id); //id'ye göre T tipindeki veriyi bulma işlemi yapıldı.
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity); //T tipindeki yeni veriyi ekleme işlemi yapıldı.
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity); //T tipindeki var olan veriyi güncelleme işlemi yapıldı.
            _context.SaveChanges();
        }
    }
}
