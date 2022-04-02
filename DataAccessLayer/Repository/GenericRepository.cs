using System;
using DataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Concrete.SmartContext;

namespace DataAccessLayer.Repository
{
    //GETASİS PDKS
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        SmartContext c = new SmartContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
        public void Delete(T p)
        {
            var deletedEntiy = c.Entry(p);
            deletedEntiy.State = EntityState.Deleted;
            // _object.Remove(p);
            c.SaveChanges();
        }
        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public T GetByID(Expression<Func<T, bool>> filter)   //Person Id ye göre getir.
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetListAll()  //Tüm Listeyi Getir.
        {
            return _object.ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)  //Tüm Listeyi Filtreli Getir.
        {
            return _object.Where(filter).ToList();
        }

       

    }
}
