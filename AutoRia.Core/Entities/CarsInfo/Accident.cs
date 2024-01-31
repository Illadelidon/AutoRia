using AutoRia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Entities.CarsInfo
{
    public class Accident : IEntity
    {
        public int Id { get; set; }
        public string YesOrNot { get; set; }
    }
}
