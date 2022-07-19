using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.MODEL.Entities
{
    public class ToDo:BaseEntity
    {
        [Required(ErrorMessage ="Boş Bırakılamaz!")]
        public string Description { get; set; }
        public bool is_completed { get; set; }
    }
}
