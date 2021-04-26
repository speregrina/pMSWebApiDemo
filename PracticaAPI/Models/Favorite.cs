using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Favorite
    {
        public int FavoriteID { get; set; }
        public long SiteID { get; set; }
        public long OwnerID { get; set; }
        public long ContractID { get; set; }
        public string ContractNumber { get; set; }
        public string LanguageID { get; set; }
        public DateTime Date { get; set; }
    }
}
