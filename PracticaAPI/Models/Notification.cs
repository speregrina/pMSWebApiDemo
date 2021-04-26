using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Notification
    {
        public int NotificationID { get; set; }
        public int NotificationTypeID { get; set; }
        public long OwnerID { get; set; }
        public long ContractID { get; set; }
        public string ContractNumber { get; set; }
        public string Message { get; set; }
        public string LinkedTo { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateShow { get; set; }
        public DateTime? DateRead { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
