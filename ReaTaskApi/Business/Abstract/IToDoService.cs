using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IToDoService//business içerisinde kullanacağım method ları bu interface içerisinde tanıtıyorum
    {
        public int AddTodo(ToDo todo);
        public int UpdateTodo(ToDo todo);
        public int DeleteTodo(ToDo id);
        List<ToDo> GetAllTodos(Expression<Func<ToDo, bool>> filter = null);

        ToDo GetById(int id);
    }
}
