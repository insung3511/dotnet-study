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
    }
}
