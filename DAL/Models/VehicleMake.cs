using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("VehicleMake")]
    public class VehicleMake
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Name { get; set; }
        [StringLength(30)]
        public string Abrv { get; set; }


        public IEnumerable<VehicleModel> Models { get; set; }
    }
}
