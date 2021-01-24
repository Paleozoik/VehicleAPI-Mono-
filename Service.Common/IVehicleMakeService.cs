using Common.Paging;
using Model.VehicleMakeDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface IVehicleMakeService
    {
        Task<PagedList<MakeDTO>> GetMakes(PagingParameters paging, string SortBy);
        Task<int> CreateMake(MakeCreateDTO make);
        Task<int> UpdateMake(MakeUpdateDTO make);
        Task<int> DeleteMake(MakeDTO make);
        Task<int> DeleteMake(int id);

    }
}
