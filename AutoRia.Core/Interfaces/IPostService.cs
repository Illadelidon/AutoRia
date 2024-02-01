using AutoRia.Core.Dto_s.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Interfaces
{
    public interface IPostService 
    {
        Task<List<PostDto>> GetAll(string id);
        Task<List<PostDto>> GetAllPost();
        Task<PostDto?> Get(int id);
        Task<EditPostDto?> GetForEdit(int id);
        Task Create(PostDto model);
        Task Update(EditPostDto model);
        Task Delete(int id);
        Task<PostDto> GetById(int id);
        Task<EditPostDto> GetByIdAsync(int id);

        Task<List<PostDto>> Search(string searchString);
    }
}
