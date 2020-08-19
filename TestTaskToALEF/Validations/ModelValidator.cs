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
            RuleFor(m => m.Id).NotNull();
            RuleFor(m => m.Value).NotEmpty().Length(0,3);
            RuleFor(m => m.Name).NotEmpty();
        }
    }
}
