using BankingMicroservice.Banking.Application.Interfaces;
using BankingMicroservice.Banking.Application.Services;
using BankingMicroservice.Banking.Data.Context;
using BankingMicroservice.Banking.Domain.Interfaces;
using BankingMicroservice.Banking_Data.Repository;
using BankingMicroservice.Domain.Bus;
using BankingMicroservice.Infrastructure.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankingMicroservices.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //ApplicationServices
            services.AddTransient<IAccountService, AccountService>();
            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
            
        }
    }
}
