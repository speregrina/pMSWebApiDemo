using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class ImagesGallery
    {
        public int ImagesGalleryID { get; set; }
        public string Url { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string subModule { get; set; }
        public int Order { get; set; }
        public string Type { get; set; }
        public string LinkedTo { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
