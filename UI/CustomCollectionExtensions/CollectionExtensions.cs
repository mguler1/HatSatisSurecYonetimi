using Business.ValidationRules;
using Dto;
using FluentValidation;

namespace UI.CustomCollectionExtensions
{
    public static class CollectionExtensions
    {
        public static void AddValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<HatSatisEkleDto>, HatSatisAddValidator>();
          

        }
    }
}