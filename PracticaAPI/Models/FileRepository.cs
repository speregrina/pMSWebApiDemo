using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class FileRepository
    {
        public long FileRepositoryID { get; set; }
        public string RecordID { get; set; }
        public string TableName { get; set; }
        public string UrlFile { get; set; }
        public string FileName { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool Status { get; set; }
    }
}
