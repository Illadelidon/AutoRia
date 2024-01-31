using AutoRia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Entities.CarsInfo
{
    public class BodyType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
