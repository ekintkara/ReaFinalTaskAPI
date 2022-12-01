using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ToDo
    {
        [Key]
        public int TodoID { get; set; }
        public string TodoName { get; set; }
        public string TodoDescription { get; set;}

        public string TodoOwner { get; set; }

        public bool IsComplete { get; set; }

        public string Comments { get; set; }

        public TodoStatus todoStatus { get; set; }




        //public ICollection<Comment> Comments {get; set;}
        //public Comment CommentDesc { get; set; } öncelikle farklı bir tablo aracılığıyla comments leri almaya çalıştım sonrasında tek tablo halinde yapmaya karar verdim
    }

    public enum TodoStatus
    {  
        created = 0, 
        progress = 1,
        done = 2
      
      
       
       

    }
}
