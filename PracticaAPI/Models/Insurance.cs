#nullable disable

namespace PracticaAPI.Models
{
    public partial class Insurance
    {
        public int InsuranceID { get; set; }
        public long ReservationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool? IsActive { get; set; }
    }
}
