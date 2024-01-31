using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Dto_s.Post
{
    public class PostDto
    {
        public int Id { get; set; }
        public string TypeCar { get; set; } = string.Empty;
        public string BrandCar { get; set; } = string.Empty;
        public string ModelCar { get; set; } = string.Empty;
        public string GraduationYear { get; set; } = string.Empty;
        public string MileageCar { get; set; } = string.Empty;
        public string BodyType { get; set; } = string.Empty;
        public string Sity { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string ProducingCountry { get; set; } = string.Empty;
        public string Accident { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string EngineVolume { get; set; }= string.Empty;
        public List<IFormFile> Imgs { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public string MainImage { get; set; } = string.Empty;
        public string UserId { get; set; }
    }
}
