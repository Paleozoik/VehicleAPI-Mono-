using System;
using System.Collections.Generic;
using System.Text;

namespace Model.VehicleModelDTOs
{
    public class ModelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakeId { get; set; }
        public string MakeName { get; set; }
    }
}
