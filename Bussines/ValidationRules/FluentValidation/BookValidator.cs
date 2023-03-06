using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Books>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookName).NotEmpty();
            RuleFor(b => b.BookName).MinimumLength(2);
            RuleFor(b => b.Sum).NotEmpty();
            RuleFor(b => b.Sum).GreaterThanOrEqualTo(2).When(b => b.CategoryId == 1);
            RuleFor(b => b.BookName).Must(StartWithA).WithMessage("kitaplar A ile başlamalı");


           


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
