using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class TypeDue
    {
        public int TypeDuesID { get; set; }
        public string TypeDues { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
    }
}
