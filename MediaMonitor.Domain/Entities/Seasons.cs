﻿using System;
using System.Collections.Generic;

namespace MediaMonitor.Domain.Entities
{
    public partial class Seasons
    {
        public int IdSeason { get; set; }
        public int? IdShow { get; set; }
        public int? Season { get; set; }
        public string Name { get; set; }
        public int? Userrating { get; set; }
    }
}
