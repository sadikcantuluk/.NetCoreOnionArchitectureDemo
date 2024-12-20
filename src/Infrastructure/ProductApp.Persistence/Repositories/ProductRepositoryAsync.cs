using ProductApp.Application.Interface.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repositories
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(ApplicationDbContext context) : base(context)
        {
        }
    }
}
