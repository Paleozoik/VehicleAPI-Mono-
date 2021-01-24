using DAL.Models;
using Common.Paging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface IVehicleMakeRepository : IGenericRepository<VehicleMake>
    {
        Task<VehicleMake> GetByIdAsync(int id);
        Task<PagedList<VehicleMake>> GetSortedPagedWithModelsAsync(PagingParameters pagingParams, string SortBy);
        Task<IEnumerable<VehicleMake>> GetAllWithModelsAsync();
    }
}
