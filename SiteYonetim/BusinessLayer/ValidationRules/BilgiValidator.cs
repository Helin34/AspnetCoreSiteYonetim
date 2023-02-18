using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BilgiValidator : AbstractValidator<Bilgi>
    {
        public BilgiValidator()
        {
            RuleFor(x => x.YoneticiName).NotEmpty().WithMessage("İsim kısmı boş geçilemez");
            RuleFor(x => x.YoneticiMail).NotEmpty().WithMessage("Mail boş geçilemez");
            RuleFor(x => x.YoneticiPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.YoneticiName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.YoneticiName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın ");
            RuleFor(x => x.YoneticiPassword).MinimumLength(8).WithMessage("Şifre 8 karakterden küçük olamaz");
            RuleFor(x => x.YoneticiPassword).MaximumLength(16).WithMessage("Şifre 8 karakterden küçük olamaz");
            RuleFor(x => x.YoneticiPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az bir büyük harf olmalıdır.");
            RuleFor(x => x.YoneticiPassword).Matches(@"[a-z]+").WithMessage("Şifre en az bir küçük harf olmalıdır.");
            RuleFor(x => x.YoneticiPassword).Matches(@"[0-9]+").WithMessage("Şifre en az bir rakam olmalıdır.");
        }
    }
}
