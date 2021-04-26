#nullable disable

namespace PracticaAPI.Models
{
    public partial class Site
    {
        public long SiteID { get; set; }
        public bool? IsAllInclusive { get; set; }
        public string LanguageID { get; set; }
        public bool? IsActive { get; set; }
    }
}
