﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderRouting.Kitchen.Domain.Common
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public DateTime Created { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
