﻿using System.Runtime.InteropServices;

namespace NzWAlks.api.Models.Domains
{
    public class Region
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //Navigation Property

        public IEnumerable<Walks> Walks { get; set; }
    }
}
