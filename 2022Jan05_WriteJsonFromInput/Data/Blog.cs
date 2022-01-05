using System;
using System.ComponentModel.DataAnnotations;

namespace WriteJsonFromInput.Data
{
    public class Blog
    {
        [Required]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogSubTitle { get; set; }
        public bool BlogHomework { get; set; }
        //public string BlogContent { get; set; }
        //public string BlogEditor { get; set; }
        public DateTime BlogCreatedTime { get; set; }

        //File Upload Class
        public bool Uploaded { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public int? FileCount { get; set; }
        public int ErrorCode { get; set; }
    }
}
