using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.BLL.RepositoryPattern.Base;
using ToDoList.BLL.RepositoryPattern.Interfaces;
using ToDoList.DAL.Context;
using ToDoList.MODEL.Entities;

namespace ToDoList.BLL.RepositoryPattern.Concrete
{
    public class ToDoRepository : Repository<ToDo>, IToDoRepository
    {
        public ToDoRepository(MyDbContext db) : base(db)
        {
        }
    }
}
