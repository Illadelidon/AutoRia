using AutoRia.Core.Dto_s.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Interfaces
{
    internal interface IImageService
    {
        Task<List<ImageDto>> GetImages(int postId);
    }
}
