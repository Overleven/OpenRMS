﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenRMS.Contexts.LocationManagement.ApplicationService.Models
{
    public class CreateLocationModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}