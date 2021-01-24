using Common.Paging;
using DAL;
using DAL.Models;  //Needs an update after placing models from DAL into models
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleMakeRepository : GenericRepository<VehicleMake>, IVehicleMakeRepository
    {
        public VehicleMakeRepository(VehicleDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<VehicleMake>> GetAllWithModelsAsync()
        {
            return await FindAll().Include(x => x.Models).ToListAsync();
        }

        public async Task<VehicleMake> GetByIdAsync(int id)
        {
            return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<PagedList<VehicleMake>> GetSortedPagedWithModelsAsync(PagingParameters pagingParams, string SortBy)
        {
            var makes = FindAll().Include(x => x.Models);
            IOrderedQueryable<VehicleMake> orderedMakes = SortBy switch
            {
                "MakeA" => makes.OrderBy(x => x.Name), //redundantno
                "MakeD" => makes.OrderByDescending(x => x.Name),
                _ => makes.OrderBy(x => x.Name),
            };
            return await PagedList<VehicleMake>.ToPagedListAsync(orderedMakes, pagingParams);
        }
    }
}
