using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ExchangeRatesDusan.Domain.Models;
using ExchangeRatesDusan.Domain.Repositories;
using ExchangeRatesDusan.Domain.Interfaces;

namespace ExchangeRatesDusan.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddExchangeRatesDusanDomain(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();            
            services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
           
            // Change in accordance to your db
            var connection = @"";
            services.AddDbContext<ExchangeRatesDusanContext>
                (options => options.UseSqlServer(connection));
            return services;
        }
    }
}
