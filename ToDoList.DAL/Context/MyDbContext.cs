using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.MAP.Configurations;
using ToDoList.MODEL.Entities;

namespace ToDoList.DAL.Context
{
   public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoConfiguration());
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
