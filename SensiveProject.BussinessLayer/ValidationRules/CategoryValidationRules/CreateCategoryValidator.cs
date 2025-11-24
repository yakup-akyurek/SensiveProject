using FluentValidation;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.ValidationRules.CategoryValidationRules
{
    public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name cannot be empty.");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category description cannot be empty.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Category name cannot exceed 20 characters.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Category name must be at least 3 characters.");
        }
    }
}
