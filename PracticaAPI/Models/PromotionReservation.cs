#nullable disable

namespace PracticaAPI.Models
{
    public partial class PromotionReservation
    {
        public int PromotionReservationID { get; set; }
        public long ReservationID { get; set; }
        public long PromotionID { get; set; }
    }
}
