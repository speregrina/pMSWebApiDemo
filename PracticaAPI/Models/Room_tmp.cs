#nullable disable

namespace PracticaAPI.Models
{
    public partial class Room_tmp
    {
        public long RoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long SiteID { get; set; }
        public string RoomNumber { get; set; }
        public long RoomTypeID { get; set; }
        public string RoomType { get; set; }
        public int? Occupancy { get; set; }
        public string ImgUrlMain { get; set; }
        public string ImgName { get; set; }
        public bool? IsActive { get; set; }
    }
}
