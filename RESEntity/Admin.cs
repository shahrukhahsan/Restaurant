﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESEntity
{
    public class Admin : Entity
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string Phone { get; set; }
    }
}
