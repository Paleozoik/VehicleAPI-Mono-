using Common.Paging;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Common
{
    public interface IVehicleModelRepository: IGenericRepository<VehicleModel>
    {
        Task<VehicleModel> GetByIdAsync(int id);
        Task<PagedList<VehicleModel>> GetSortedPagedFilteredWithMakeAsync(PagingParameters pagingParams, string SortBy, int? MakeFilter);
        Task<IEnumerable<VehicleModel>> GetAllWithMakesAsync();
    }
}
