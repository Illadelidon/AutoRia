using AutoMapper;
using AutoRia.Core.Dto_s.Post;
using AutoRia.Core.Entities.Site;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.AutoMapper.Posts
{
    public class AutoMapperPost : Profile
    {
        public AutoMapperPost()
        {
            CreateMap<PostDto, Post>().ReverseMap();
            CreateMap<ImageDto, PostsImg>().ReverseMap();
            CreateMap<FormFile, PostsImg>();
        }
    }
}
