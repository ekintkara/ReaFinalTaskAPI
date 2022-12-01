using Business.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TodoMan : IToDoService //interface imi kalıtıyorum ve implement ediyorum
    {
        IToDoDal _tododal; //dal dan bir nesne kullanıyorum 
        public TodoMan(IToDoDal tododal)//construtor ımı oluşturuyorum
        {
            _tododal = tododal;
        }

        public int AddTodo(ToDo todo)
        {
            return _tododal.TodoAdd(todo);
        }

        public int DeleteTodo(ToDo id)
        {
            return _tododal.TodoRemove(id);
        }

        public List<ToDo> GetAllTodos(Expression<Func<ToDo, bool>> filter = null)
        {
            return _tododal.GetAll();
        }

        public int UpdateTodo(ToDo todo)
        {
            return _tododal.TodoUpdate(todo);
        }

        public ToDo GetById(int id)
        {
            return _tododal.GetById(id);
        }

    }
}
