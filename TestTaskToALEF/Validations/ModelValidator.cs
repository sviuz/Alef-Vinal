using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTaskToALEF.Models;

namespace TestTaskToALEF.Validations
{
    public class ModelValidator : AbstractValidator<Model>//Fluent Validation
    {
        public ModelValidator()
        {
            RuleFor(m => m.Id).NotNull();//поле Id не должно быть пустым
            RuleFor(m => m.Value).NotEmpty().Length(0,3);//поле value не должно быть в пределах от 0 до 3
            RuleFor(m => m.Name).NotEmpty();//поле Name не должно быть пустым
        }
    }
}
