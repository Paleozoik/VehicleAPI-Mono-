using Common.Paging;
using Model.VehicleModelDTOs;
using Service.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VehicleModelService : IVehicleModelService
    {
        public Task<int> CreateModel(ModelCreateDTO Model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteModel(ModelDTO Model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteModel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<ModelDTO>> GetModels(PagingParameters paging, string SortBy)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateModel(ModelUpdateDTO Model)
        {
            throw new NotImplementedException();
        }
    }
}
