using Business.Implements;
using Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories.IGenericRepository;
using Repositories.IRepositories;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddTransient<IDisciplineRepository, DisciplineRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeSalaryRepository, EmployeeSalaryRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRewardRepository, RewardRepository>();

            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();
            services.AddScoped<IRewardBusiness, RewardBusiness>();
            services.AddScoped<IEmployeeSalaryBusiness, EmployeeSalaryBusiness>();
            services.AddScoped<IDisciplineBusiness, DisciplineBusiness>();


        }
    }
}
