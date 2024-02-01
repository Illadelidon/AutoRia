using AutoMapper;
using AutoRia.Core.Dto_s.Post;
using AutoRia.Core.Entities.Site;
using AutoRia.Core.Entities.Specifications;
using AutoRia.Core.Entities.User;
using AutoRia.Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Services
{
    public class PostService : IPostService 
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IRepository<Post> _postRepo;
        private readonly IRepository<PostsImg> _imgRepo;
        private readonly UserManager<AppUser> _userManager;
        
        

        public PostService(IConfiguration configuration, IRepository<Post> postRepo, IMapper mapper, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> userManager, IRepository<PostsImg> imgRepo)
        {
            _mapper = mapper;
            _postRepo = postRepo;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
            _imgRepo = imgRepo;

        }
        public async Task Create(PostDto model)
        {
            var post = _mapper.Map<Post>(model);

            if (model.Imgs != null && model.Imgs.Any())
            {
                var imgList = new List<PostsImg>();
                string webRootPath = _webHostEnvironment.WebRootPath;
                string upload = Path.Combine(webRootPath, "img");

               
                if (!Directory.Exists(upload))
                {
                    Directory.CreateDirectory(upload);
                }

                foreach (var imgFile in model.Imgs)
                {
                    string fileName = Guid.NewGuid().ToString();
                    string extensions = Path.GetExtension(imgFile.FileName);

                    using (var filestream = new FileStream(Path.Combine(upload, fileName + extensions), FileMode.Create))
                    {
                        imgFile.CopyTo(filestream);
                    }

                    var img = new PostsImg
                    {
                        ImagePath = fileName + extensions
                    };

                    imgList.Add(img);
                }
                post.MainImage = imgList.FirstOrDefault()?.ImagePath;

                post.Imgs = imgList;
            }

            await _postRepo.Insert(post);
            await _postRepo.Save();
        }


       


        



        public async Task Delete(int id)
        {
            var currentPost = await Get(id);

            if (currentPost == null) return; // exception

            await _postRepo.Delete(id);
            await _postRepo.Save();
        }

        public async Task<PostDto?> Get(int id)
        {
            if (id < 0) return null; // exception handling

            var post = await _postRepo.GetByID(id);

            if (post == null) return null; // exception handling

            return _mapper.Map<PostDto>(post);
        }

        public async Task<List<PostDto>> GetAll(string currentUserId)
        {
            if (!string.IsNullOrEmpty(currentUserId))
            {
                var result = await _postRepo.GetListBySpec(new Posts.ByUserId(currentUserId));

                return _mapper.Map<List<PostDto>>(result);
            }
            return new List<PostDto>();
        }

      

        public async Task<List<PostDto>> GetAllPost()
        {
            var result = await _postRepo.GetAll(new Post());

            return _mapper.Map<List<PostDto>>(result);
        }


        public async Task<PostDto> GetById(int id)
        {
            if (id < 0) return null; // exception handling

            var post = await _postRepo.GetByID(id);

            if (post == null) return null; // exception handling

            return _mapper.Map<PostDto>(post);
        }

        public async Task<EditPostDto?> GetForEdit(int id)
        {
            if (id < 0) return null; // exception handling

            var post = await _postRepo.GetByID(id);

            if (post == null) return null; // exception handling

            return _mapper.Map<EditPostDto>(post);
        }

        public Task<List<PostDto>> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public async Task Update(EditPostDto model)
        {
            var currentPost = await _postRepo.GetByID(model.Id);
            /*if (imageDto.File.Count > 0)
            {
                string webRootPath = _webHostEnvironment.WebRootPath;
                string upload = Path.Combine(webRootPath, "img");

                string existingFilePath = Path.Combine(upload, currentPost.MainImage);

                if (File.Exists(existingFilePath) && model.MainImage != null)
                {
                    File.Delete(existingFilePath);
                }

                var files = imageDto.File;

                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                model.MainImage = fileName + extension;

            }
            else
            {
                model.MainImage = currentPost.MainImage;
            }*/

            model.MainImage = currentPost.MainImage;
            model.UserId = currentPost.UserId;

            await _postRepo.Update(_mapper.Map<Post>(model));
            await _postRepo.Save();
        }
        public async Task<EditPostDto> GetByIdAsync(int id)
        {
            var post= await _postRepo.GetByID(id);

            var mappedPost= _mapper.Map<Post, EditPostDto>(post);

            return mappedPost;
        }
    }
}
