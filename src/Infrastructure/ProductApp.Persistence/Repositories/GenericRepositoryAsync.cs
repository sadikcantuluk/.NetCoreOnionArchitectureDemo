using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interface.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repositories
{
    public class GenericRepositoryAsync<T> : GenereicRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepositoryAsync(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }
    }
}
