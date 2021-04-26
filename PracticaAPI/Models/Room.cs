#nullable disable

namespace PracticaAPI.Models
{
    public partial class Room
    {
        public long RoomID { get; set; }
        public long SiteID { get; set; }
        public int? Occupancy { get; set; }
        public string ImgUrlMain { get; set; }
        public string ImgName { get; set; }
        public bool? IsActive { get; set; }
    }
}
