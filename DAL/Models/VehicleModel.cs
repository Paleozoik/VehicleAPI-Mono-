using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    [Table("VehicleModel")]
    public class VehicleModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(VehicleMake))]
        public int MakeId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Name { get; set; }
        public string Abrv { get; set; }


        public VehicleMake Make { get; set; }
    }
}
