using Common.Paging;
using DAL.Models;
using Model.VehicleMakeDTOs;
using Repository.Common;
using Service.Common;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class VehicleMakeService : IVehicleMakeService
    {
        public Task<int> CreateMake(MakeCreateDTO make)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteMake(MakeDTO make)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteMake(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<MakeDTO>> GetMakes(PagingParameters paging, string SortBy)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateMake(MakeUpdateDTO make)
        {
            throw new NotImplementedException();
        }
    }
}
