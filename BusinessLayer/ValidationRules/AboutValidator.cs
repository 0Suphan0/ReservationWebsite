using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator: AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen resim giriniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Minimum 50 karakter girilmelidir.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Maximum 1500 karakter girilmelidir.");



        }
    }
}
