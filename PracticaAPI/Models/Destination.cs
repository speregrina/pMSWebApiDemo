#nullable disable

namespace PracticaAPI.Models
{
    public partial class Destination
    {
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public string LanguageID { get; set; }
        public bool? IsActive { get; set; }
    }
}
