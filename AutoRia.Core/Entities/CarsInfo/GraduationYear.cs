﻿using AutoRia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Entities.CarsInfo
{
    public class GraduationYear : IEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
    }
}
