﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class CoffeeShop
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string OpeningHours { get; set; } = string.Empty;
        public string? Address { get; set; } 
    }
}
