using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //contex imden yeni bir nesne türetiyorum işlerim kolaylaşsın diye
        Context c= new Context();
        DbSet<T> o;

        //constructor oluşturuyorum
        public Repository()
        {
            o = c.Set<T>();
        }
        //tüm taskları görmemi sağlayan method
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return o.ToList();
        }
        //ekleme yaptığım method
        public int TodoAdd(T e)
        {
            o.Add(e);
            return c.SaveChanges();
        }
        //silme yaptığım method
        public int TodoRemove(T e)
        {
            o.Remove(e);
            return c.SaveChanges();
        }
        //update yaptığım method
        public int TodoUpdate(T e)
        {
            o.Update(e);
            return c.SaveChanges();
        }
        //ID yi çektiğim method
        public T GetById(int id)
        {
            return o.Find(id);
        }

  
    }
}
