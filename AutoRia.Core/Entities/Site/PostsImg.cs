using Ardalis.Specification;
using AutoRia.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Entities.Site
{
    public class PostsImg : IEntity
    {
        public int Id { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public string ImagePath { get; set; } 
        public Post Post { get; set; }


    }
}
