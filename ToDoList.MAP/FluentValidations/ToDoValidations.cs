using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.MODEL.Entities;

namespace ToDoList.MAP.FluentValidations
{
   public class ToDoValidations:AbstractValidator<ToDo>
    {
        public ToDoValidations()
        {
            RuleFor(x => x.Description).NotNull().NotEmpty().WithMessage("Bu Alan Boş bırakılamaz!.");
        }
    }
}
