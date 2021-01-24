using Common.Paging;
using Model.VehicleModelDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public interface IVehicleModelService
    {
        Task<PagedList<ModelDTO>> GetModels(PagingParameters paging, string SortBy);
        Task<int> CreateModel(ModelCreateDTO Model);
        Task<int> UpdateModel(ModelUpdateDTO Model);
        Task<int> DeleteModel(ModelDTO Model);
        Task<int> DeleteModel(int id);
    }
}
