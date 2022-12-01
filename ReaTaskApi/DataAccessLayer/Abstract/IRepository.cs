using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //generic hale getiriyorum // methodlarımı burada tanıtıp repomda çağırıyorum uzun uzun yazmak zorunda kalmıyorum
    {
        public int TodoAdd(T e);
        public int TodoRemove(T e);
        public int TodoUpdate(T e);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetById(int id);

    }
}
