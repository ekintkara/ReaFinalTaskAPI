using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IToDoDal:IRepository<ToDo>//interface üzerinde değişiklikler yapmak zorunda kalırsam ve bu değişikliğin sadece todo için olmasını istediğim için oluşturuyorum burayı
    {
    }
}
