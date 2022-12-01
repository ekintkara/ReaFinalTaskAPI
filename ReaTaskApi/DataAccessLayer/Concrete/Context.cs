using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Db bağlantılarımı yapıyorum
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\EKIN;Database=ReaFinalTasktodo2;Trusted_Connection=true");
        }

        public DbSet<ToDo> toDos { get; set; }//Db de oluşacak tablolarımı belirtiyorum
       

    }
}
//Burası için eklediğim nugget lar EnttiyFramework-Tools-SqlServer