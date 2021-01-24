using DAL;
using DAL.Models;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleMakeUnitOfWork : UnitOfWork<VehicleMake>, IVehicleMakeUnitOfWork
    {
        private readonly VehicleDbContext DbContext;
        public VehicleMakeUnitOfWork(VehicleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
