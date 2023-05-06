using Business.Concrete;
using Business.Interface;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DIContainer
{
    public static class CustomExtensions
    {
        public static void AddContainer(this IServiceCollection services)
        {
            services.AddScoped<IHatSatisService, HatSatisManager>();
            services.AddScoped<IHatSatisDal, EfHatSatisRepository>();

            services.AddScoped<IHatService, HatManager>();
            services.AddScoped<IHatDal, EfHatRepository>();


            services.AddScoped<IHatKullanimService, HatKullanimManager>();
            services.AddScoped<IHatKullanimDal, EfHatKullanimRepository>();

            services.AddScoped<IEmailService, EmailManager>();
            services.AddScoped<IElasticsearchService, ElasticsearchManager>();


        }
    }
}