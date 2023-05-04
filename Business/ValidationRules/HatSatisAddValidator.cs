using Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class HatSatisAddValidator:AbstractValidator<HatSatisEkleDto>
    {
        public HatSatisAddValidator()
        {
            RuleFor(x => x.Ad).NotNull().WithMessage("Ad Boş Geçilemez").MaximumLength(50);
            RuleFor(x => x.Soyad).NotNull().WithMessage("Soyad Boş Geçilemez").MaximumLength(50);
            RuleFor(x => x.Il).NotNull().WithMessage("İl Boş Geçilemez");
            RuleFor(x => x.Ilce).NotNull().WithMessage("İlçe Boş Geçilemez");
            RuleFor(x => x.Adres).NotNull().WithMessage("Adres Boş Geçilemez").MaximumLength(100);
            RuleFor(x => x.HatId).ExclusiveBetween(0, int.MaxValue).WithMessage("Bir Hat Seçiniz");
        }
    }
}
