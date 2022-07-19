using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.BLL.RepositoryPattern.Interfaces;
using ToDoList.DAL.Context;
using ToDoList.MODEL.Entities;

namespace ToDoList.Controllers
{
    public class TodoListController : Controller
    {
        MyDbContext _db;
        IToDoRepository _repo;
        public TodoListController(MyDbContext db,IToDoRepository repo)
        {
            _db = db;
            _repo = repo;
        }
        public IActionResult Index()
        {
            List<ToDo> todo = _repo.GetByActives();
            return View(todo);
        }
        public IActionResult Edit(int id)
        {
            ToDo todo = _repo.GetById(id);
            return View(todo);
        }
        [HttpPost]
        public IActionResult Edit(ToDo todo)
        {
            _repo.Update(todo);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult isCompleted(int id)
        {
            ToDo todo = _repo.GetById(id);
            if (todo.is_completed == true)
            {
                todo.is_completed = false;
            }
            else
            {
                todo.is_completed = true;
            }
           
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
