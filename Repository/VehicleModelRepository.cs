using Common.Paging;
using DAL;
using DAL.Models;
using Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VehicleModelRepository : GenericRepository<VehicleModel>, IVehicleModelRepository
    {
        public VehicleModelRepository(VehicleDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<VehicleModel>> GetAllWithMakesAsync()
        {
            return await FindAll().Include(x => x.Make).ToListAsync();
        }

        public async Task<VehicleModel> GetByIdAsync(int id)
        {
            return await FindByCondition(x => x.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<PagedList<VehicleModel>> GetSortedPagedFilteredWithMakeAsync(PagingParameters pagingParams, string SortBy, int? MakeFilter)
        {
            var models = FindByCondition(x => x.MakeId == MakeFilter || MakeFilter == null).Include(x => x.Make);
            IOrderedQueryable<VehicleModel> orderedModels = SortBy switch
            {
                "MakeA" => models.OrderBy(x => x.Make.Name), //redundantno
                "MakeD" => models.OrderByDescending(x => x.Make.Name),
                "ModelA" => models.OrderBy(x => x.Name),
                "ModelD" => models.OrderByDescending(x => x.Name),
                _ => models.OrderBy(x => x.Name),
            };
            return await PagedList<VehicleModel>.ToPagedListAsync(orderedModels, pagingParams);
        }
    }
}
