using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ExchangeRatesDusan.Domain.IoC;
using ExchangeRatesDusan.Domain.Interfaces;
using ExchangeRatesDusan.Domain.Repositories;
using ExchangeRatesDusan.Domain.Models;

namespace ExchangeRatesDusan.Business.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddExchangeRatesDusanBusiness(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ExchangeRatesDusanContext, ExchangeRatesDusanContext>();         

            services.AddExchangeRatesDusanDomain();            
            return services;
        }
    }
}
