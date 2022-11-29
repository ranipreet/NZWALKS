﻿using NzWAlks.api.Models.Domains;

namespace NzWAlks.api.Models.DTO
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
