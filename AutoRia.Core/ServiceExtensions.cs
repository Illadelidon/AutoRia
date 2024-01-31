﻿using AutoRia.Core.AutoMapper.Posts;
using AutoRia.Core.AutoMapper.User;
using AutoRia.Core.Interfaces;
using AutoRia.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core
{
    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<UserServices>();

            services.AddScoped<IPostService, PostService>();

        }
        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperUser));
            services.AddAutoMapper(typeof(AutoMapperPost));

        }
    }
}
