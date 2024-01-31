using Ardalis.Specification;
using AutoRia.Core.Entities.Site;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AutoRia.Core.Entities.Specifications
{
    public class Posts : Specification<Post>
    {



        public class ByUserId : Specification<Post>
        {
            private readonly string _userId;
            public ByUserId(string userId)
            {

                Query
            .Where(p => p.UserId == userId)
            .OrderByDescending(p => p.Id);

            }
        }


    }
}
