using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoRia.Core.Interfaces;
using AutoRia.Core.Entities.User;

namespace AutoRia.Core.Entities.Site
{
    public class Post : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TypeCar { get; set; }
        public string BrandCar { get; set; }
        public string ModelCar { get; set; }
        public string GraduationYear { get; set; }
        public string MileageCar { get; set; }
        public string BodyType { get; set; }
        public string Sity { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string ProducingCountry { get; set; }
        public string Accident { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public string Phone { get; set; }
        public string UserId { get; set; }
        public string Number { get; set; }
        public string EngineVolume { get; set; }
        public AppUser User { get; set; }
        public List<PostsImg> Imgs { get; set; }
        public string MainImage { get; set; }
    }
}
