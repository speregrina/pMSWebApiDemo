using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Site_tmp
    {
        public long SiteID { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string country { get; set; }
        public string CP { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool IsAllInclusive { get; set; }
        public TimeSpan? CheckIn { get; set; }
        public TimeSpan? CheckOut { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
        public string LanguageID { get; set; }
        public int DestinationID { get; set; }
        public bool IsActive { get; set; }
    }
}
