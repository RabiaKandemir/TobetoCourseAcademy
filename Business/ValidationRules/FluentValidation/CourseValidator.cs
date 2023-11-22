using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(c=>c.Name).NotEmpty();
            RuleFor(c=>c.Name).MinimumLength(3);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c=>c.Price).GreaterThanOrEqualTo(0);
            RuleFor(c => c.Name).Must(StartWithA).WithMessage("Kurs ismi A ile başlamalı...");
        }

        private bool StartWithA(string arg)
        {
           return arg.StartsWith("A");
        }
    }
}
