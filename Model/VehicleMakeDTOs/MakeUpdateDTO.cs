﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.VehicleMakeDTOs
{
    public class MakeUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string Name { get; set; }
    }
}
