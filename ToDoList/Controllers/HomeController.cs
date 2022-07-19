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
    public class HomeController : Controller
    {
        IToDoRepository _repo;
        public HomeController(IToDoRepository repo)
        {
            _repo = repo;
        }
        public IActionResult ToDo()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                
                return RedirectToAction("ToDo");
            }
            _repo.Add(toDo);
            return RedirectToAction("ToDo");
        }

    }
}
