﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuningCarParts.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City{ get; set; }
        public string EirCode { get; set; }

        public string urlParam { get; set; }
    }
}