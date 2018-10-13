using FlightService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        Task<T> GetByIdAsync(int id);

        Task<T> AddAsync(T item);

        Task<T> UpdateAsync(int id, T item);

        Task<T> DeleteAync(int id);

        //Task<T> GetByFiltersAsync(FlightSchedules flightSchedules);

    }
}
