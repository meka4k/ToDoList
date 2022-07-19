using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.MODEL.Enums;

namespace ToDoList.MODEL.Entities
{
   public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = Enums.DataStatus.Inserted;
        }
        public int ID { get; set; }     
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
