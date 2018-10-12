using FlightService.Infrastructure;
using FlightService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly FlightServiceContext _dbContext;
        private readonly DbSet<T> entity;

        public Repository(FlightServiceContext dbContext)
        {
            _dbContext = dbContext;
            entity = dbContext.Set<T>();
        }

        public async Task<T> AddAsync(T item)
        {
            entity.Add(item);
            await _dbContext.SaveChangesAsync();
            return item;
        }

        public async Task<T> DeleteAync(int id)
        {
            var item = await entity.FindAsync(id);
            if(item != null)
            {
                entity.Remove(item);
                await _dbContext.SaveChangesAsync();
            }
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return this.entity.ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.entity.FindAsync(id);
        }

        public async Task<T> UpdateAsync(int id, T item)
        {
            if (id != item.Id)
            {
                throw new Exception("item with given id not found");
            }
            var result = this.entity.Update(item);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        //public IEnumerable<T> GetByFiltersAsync(FlightSchedules flightSchedules)
        //{
        //    var result = this.entity.ToList();
        //    return result;
        //}
    }
}
