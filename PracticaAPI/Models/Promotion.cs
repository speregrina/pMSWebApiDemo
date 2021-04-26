using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Promotion
    {
        public long PromotionID { get; set; }
        public int? PromotionTypeID { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool Status { get; set; }
    }
}
