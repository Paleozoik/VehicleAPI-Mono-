using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.VehicleModelDTOs
{
    public class ModelCreateDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Name { get; set; }
        [Required]
        public int MakeId { get; set; }
    }
}
