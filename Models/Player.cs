﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISandbox.Models
{
    public class Player: BaseEntity
    {
        public string Name { get; set; }
        public int Points { get; set; }
    }
}
