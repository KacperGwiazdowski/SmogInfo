﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmogInfo.Model
{
    public class StationPointDto
    {
        public int ID { get; set; }

        public string StreetName { get; set; }

        public ICollection<SmogLevel> SmogLevels { get; set; } = new List<SmogLevel>();



    }
}
