using AutoMapper;
using AutoRia.Core.Dto_s.User;
using AutoRia.Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.AutoMapper.User
{
    public class AutoMapperUser : Profile
    {
        public AutoMapperUser()
        {
            CreateMap<UsersDto, AppUser>().ReverseMap();
            CreateMap<EditUserDto, AppUser>().ForMember(dest => dest.Id, opt => opt.Ignore()).ReverseMap();
            CreateMap<RegisterDto, AppUser>().ForMember(dst => dst.UserName, act => act.MapFrom(src => src.Email));
            CreateMap<AppUser, RegisterDto>();
        }
    }
}
