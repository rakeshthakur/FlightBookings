﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Models
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
    }
}
