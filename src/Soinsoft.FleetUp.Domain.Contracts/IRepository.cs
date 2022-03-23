using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Entities;
using Soinsoft.FleetUp.Domain.Entities.Interfaces;

namespace Soinsoft.FleetUp.Domain.Contracts
{
    public interface IRepository<T> where T: IAggregate
    {
        Task<IEnumerable<T>> GetAll();
        T Get();
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveAsync();

    }
}