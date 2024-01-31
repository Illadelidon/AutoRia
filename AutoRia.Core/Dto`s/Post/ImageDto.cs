using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRia.Core.Dto_s.Post
{
    public class ImageDto
    {
        public int Id { get; set; }

        private string? _imagePath;
        public string? ImagePath
        {
            get => _imagePath;
            set => _imagePath = value ?? defaultPath;
        }
        const string defaultPath = "Default.png";

        public int PostId { get; set; }
        public IFormFileCollection File { get; set; }

    }
}
