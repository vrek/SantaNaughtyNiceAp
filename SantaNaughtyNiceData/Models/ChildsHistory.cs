using System.ComponentModel.DataAnnotations;

namespace SantaNaughtyNiceData.Models
{
    public class ChildsHistory
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ChildID { get; set; }
        [Required]
        public int ActivityID { get; set; }
        [Required]
        public int DeltaANNS { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
