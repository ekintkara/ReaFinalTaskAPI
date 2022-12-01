using Business.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ReaFinal.api.Controllers
{
    [Route("api/[controller]")]   //api olduğunu ve route unu söylüyorum burada
    [ApiController]

    public class MainController : ControllerBase 
    {
        private IToDoService toDoService; //business ımda oluşturduğum methodlarımı kullanabilmek için

        public MainController(IToDoService toDoService)//constructor ımı oluşturuyorum
        {
            this.toDoService = toDoService;
        }

        [HttpGet("{id}")]
        public ToDo Get(int id) //id ile çekme
        {
            return toDoService.GetById(id); 
        }
        

        [HttpGet]
        [Route("Get")]
        public List<ToDo> Get() //genel hepsini çekmek için
        {
            return toDoService.GetAllTodos();
        }

        [HttpPost]
        [Route("Post")]
        public int Post([FromBody] ToDo toDo)// post işlemimi yapıyorum
        {
            return toDoService.AddTodo(toDo);
        }
        [HttpPut]
        [Route("Put")]
        public int Put([FromBody] ToDo toDo)//put yani update işlemimi yapıyorum
        {
            return toDoService.UpdateTodo(toDo);
        }

   
        [HttpDelete]
        [Route("Delete")]
        public void Delete(int id) //delete işlemi
        {
            var todo= toDoService.GetById(id);
            toDoService.DeleteTodo(todo);
        }
    }
}
//sonra startup a geçiyorum