using DAL;
using DAL.Models;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class VehicleModelUnitOfWork : UnitOfWork<VehicleModel>, IVehicleModelUnitOfWork
    {
        private VehicleDbContext DbContext;
        public VehicleModelUnitOfWork(VehicleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
