using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.MODEL.Entities;

namespace ToDoList.BLL.RepositoryPattern.Interfaces
{
    public interface IToDoRepository:IRepository<ToDo>
    {
    }
}
