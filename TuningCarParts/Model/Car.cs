﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TuningCarParts.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year  { get; set; }
        [Required]
        public double Miles{ get; set; }
        [Required]
        public string Color { get; set; }
        public string UserID { get; set; }
       
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser{ get; set; }

    }
}
