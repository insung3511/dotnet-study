using System;
namespace WriteJsonFromInput.Data
{
    public class UploadResult
    {
        public bool UploadedBool { get; set; }
        public string? FileName { get; set; }
        public string? StoredFileName { get; set; }
        public int ErrorCode { get; set; }
    }
}
