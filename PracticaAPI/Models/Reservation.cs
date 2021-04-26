using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Reservation
    {
        public long ReservationID { get; set; }
        public long OwnerID { get; set; }
        public string ContractNumber { get; set; }
        public string UrlDocument { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
