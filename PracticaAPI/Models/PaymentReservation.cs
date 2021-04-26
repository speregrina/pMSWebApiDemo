using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class PaymentReservation
    {
        public int PaymentReservationID { get; set; }
        public long ReservationID { get; set; }
        public string Description { get; set; }
        public long? CurrencyID { get; set; }
        public string CurrencySymbol { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public int? NumberPayment { get; set; }
        public long? TransactionNumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DatePayment { get; set; }
        public bool? IsActive { get; set; }
    }
}
