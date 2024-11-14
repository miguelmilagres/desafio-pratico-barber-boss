﻿using BarberBoss.Domain.Entities;
using BarberBoss.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BarberBoss.Infrastructure.DataAccess.Repositories
{
    internal class ServiceRepository : IServicesReadOnlyRepository, IServicesWriteOnlyRepository
    {
        private readonly BarberBossDbContext _dbContext;

        public ServiceRepository(BarberBossDbContext dbContext)
        {
            _dbContext = dbContext;    
        }
        public async Task Add(Service service)
        {
            await _dbContext.Services.AddAsync(service);
        }

        public async Task<List<Service>> GetAll()
        {
            return await _dbContext.Services.AsNoTracking().ToListAsync();
        }

        public async Task<Service?> GetById(long id)
        {
            return await _dbContext.Services.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
