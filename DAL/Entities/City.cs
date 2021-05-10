﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Hospital> Hospitals { get; set; }
    }
}
