using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Soinsoft.FleetUp.Domain.Contracts;
using Soinsoft.FleetUp.Domain.Entities;

namespace Soinsoft.FleetUp.Infra.Persistence.Repositories
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        public void Delete(WorkOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkOrder>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<WorkOrder> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(WorkOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(WorkOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}