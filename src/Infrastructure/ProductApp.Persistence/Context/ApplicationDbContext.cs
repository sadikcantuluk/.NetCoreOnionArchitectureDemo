using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 122, CreateTime = DateTime.Now.Date },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 24, Quantity = 89, CreateTime = DateTime.Now.Date },
                new Product() { Id = Guid.NewGuid(), Name = "Calculate Machine", Value = 17, Quantity = 32, CreateTime = DateTime.Now.Date }

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
