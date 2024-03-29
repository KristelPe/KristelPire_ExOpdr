﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KristelPire_ExOpdr.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DateTime Date { get; set; }
        public string LicensePlate { get; set; }
        public Owner Owner { get; set; }
        public CarType Type { get; set; }
    }
}
