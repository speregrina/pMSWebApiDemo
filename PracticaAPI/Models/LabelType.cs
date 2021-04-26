using System;

#nullable disable

namespace PracticaAPI.Models
{
    public partial class LabelType
    {
        public int LabelTypeID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
