﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interface.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
        }
    }
}
