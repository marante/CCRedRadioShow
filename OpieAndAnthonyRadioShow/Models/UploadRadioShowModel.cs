using Microsoft.AspNetCore.Http;

namespace OpieAndAnthonyRadioShow.Models
{
    public class UploadRadioShowModel
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public IFormFile RadioShowUpload { get; set; }
    }
}
