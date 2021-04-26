using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Due
    {
        public int DueID { get; set; }
        public int TypeDuesID { get; set; }
        public long OwnerID { get; set; }
        public string ContractNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool PaidUp { get; set; }
        public DateTime? PaidDate { get; set; }
    }
}
