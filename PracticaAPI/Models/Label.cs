using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class Label
    {
        public int LabelID { get; set; }
        public string KeyCode { get; set; }
        public string LanguageID { get; set; }
        public string Label1 { get; set; }
        public string Module { get; set; }
        public int LabelTypeID { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool Status { get; set; }
    }
}
