using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ToDoDal : Repository<ToDo> ,IToDoDal //solid prensiplerine uysun ileride todo için yapacağım yeni methodları rahat bir şekilde kullanabilmek için oluşturuyorum burayı
    {
    }
}
